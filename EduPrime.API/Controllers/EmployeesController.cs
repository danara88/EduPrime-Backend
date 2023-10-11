using AutoMapper;
using EduPrime.API.Attributes;
using EduPrime.API.Helpers;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.AzureServices;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EduPrime.API.Controllers
{
    [Route("api/employees/v1")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepositoryService _employeeRepositoryService;
        private readonly IBlobStorageService _blobStorageService;
        private readonly IFileHelper _fileHelper;
        private readonly AzureSettings _azureSettings;
        private readonly IMapper _mapper;

        public EmployeesController(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IEmployeeRepositoryService employeeService,
            IBlobStorageService blobStorageService,
            IOptions<AzureSettings> azureSettings,
            IFileHelper fileHelper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _employeeRepositoryService = employeeService;
            _blobStorageService = blobStorageService;
            _azureSettings = azureSettings.Value;
            _fileHelper = fileHelper;
        }

        /// <summary>
        /// End point to return all employees
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _unitOfWork.EmployeeRepository.GetAllAsync();
            var employeesDTO = _mapper.Map<List<EmployeeDTO>>(employees);

            return Ok(new ApiResponse<List<EmployeeDTO>>(employeesDTO));
        }

        /// <summary>
        /// End point to get an employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);
            if (employee is null)
            {
                return NotFound();
            }
            var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
            var response = new ApiResponse<EmployeeDTO>(employeeDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to create an employee
        /// </summary>
        /// <param name="createEmployeeDTO"></param>
        /// <returns></returns>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-employee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO createEmployeeDTO)
        {
            createEmployeeDTO.Areas = createEmployeeDTO.Areas?.Distinct().ToList();
            var employee = _mapper.Map<Employee>(createEmployeeDTO);

            try
            {
                if (employee.Areas.Count == 0)
                {
                    if (employee.Professor is not null)
                    {
                        throw new Exception();
                    }

                    await _unitOfWork.EmployeeRepository.AddAsync(employee);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    if (employee.Professor is not null)
                    {
                        var areas = await _unitOfWork.AreaRepository.GetAllAsync();
                        var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));
                        if (professorArea is not null)
                        {
                            if (!employee.Areas.Any(a => a.Id == professorArea.Id))
                            {
                                throw new Exception();
                            }
                        } 
                        else
                        {
                            throw new Exception();
                        }
                    }
                    await _employeeRepositoryService.AddEmployeeWithAreasToDB(employee);
                }
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
            var response = new ApiResponse<EmployeeDTO>(employeeDTO)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to upload a RFC document to an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-employee-rfc/{employeeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadRFCDocument([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO, int employeeId)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(employeeId);
            if (employee is null)
            {
                throw new BadRequestException($"The employee with id {employeeId} does not exist.");
            }

            if (!_fileHelper.IsValidBase64Pdf(uploadEmployeeFileDTO.fileBase64))
            {
                throw new BadRequestException("The file must be a PDF file.");
            }

            var containerName = _azureSettings.EmployeesRfcsContainer;
            try
            {
                if (!string.IsNullOrEmpty(uploadEmployeeFileDTO.fileBase64))
                {
                    string newFileName = GenerateFileName("rfc.pdf", employee);
                    employee.RfcDocument = newFileName;
                    await _blobStorageService.UploadFileBlobAsync(newFileName, uploadEmployeeFileDTO.fileBase64, containerName);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception();
                }

                var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
                var response = new ApiResponse<EmployeeDTO>(employeeDTO);

                return Ok(response);
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }

        /// <summary>
        /// End point to upload a picture for an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-employee-picture/{employeeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadEmployeePicture([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO, int employeeId)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(employeeId);
            if (employee is null)
            {
                throw new BadRequestException($"The employee with id {employeeId} does not exist.");
            }

            var validBase64Image = _fileHelper.IsValidBase64Image(uploadEmployeeFileDTO.fileBase64);
            if (!validBase64Image.Item1)
            {
                throw new BadRequestException("The file must be a png or jpg image.");
            }

            var containerName = _azureSettings.EmployeesPicturesContainer;
            try
            {
                if (!string.IsNullOrEmpty(uploadEmployeeFileDTO.fileBase64))
                {
                    var pictureFileName = GeneratePictureFileName($"picture.{validBase64Image.Item2}", employee);
                    employee.PictureURL = await _blobStorageService.UploadFileBlobAsync(pictureFileName, uploadEmployeeFileDTO.fileBase64, containerName);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception();
                }

                var employeeDTO = _mapper.Map<EmployeeDTO>(employee);
                var response = new ApiResponse<EmployeeDTO>(employeeDTO);

                return Ok(response);
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }

        /// <summary>
        /// Downloads the RFC document from an employee 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [Authorize]
        [HttpGet("download-employee-rfc/{employeeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DownloadRFCFile(int employeeId)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(employeeId);
            if (employee is null)
            {
                throw new BadRequestException($"The employee with id {employeeId} does not exist.");
            }

            if (employee.RfcDocument is null)
            {
                throw new BadRequestException($"The employee doesn't have any RFC document.");
            }

            try
            {
                Stream blobStream = await _blobStorageService.DownloadBlobInBrowserAsync(_azureSettings.EmployeesRfcsContainer, employee.RfcDocument);
                Response.Headers.Add("Content-Disposition", "attachment; filename=" + employee.RfcDocument);
                return File(blobStream, "application/octet-stream");
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
           
        }

        /// <summary>
        /// End point to update an employee
        /// </summary>
        /// <param name="updateEmployeeDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDTO updateEmployeeDTO)
        {
            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(updateEmployeeDTO.Id);
            if (employeeDB is null)
            {
                throw new BadRequestException($"The employee with id {updateEmployeeDTO.Id} does not exist.");
            }

            employeeDB = _mapper.Map(updateEmployeeDTO, employeeDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// End point to delete an employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(id);
            if (employeeDB is null)
            {
                throw new BadRequestException($"The employee with id {id} does not exist.");
            }

            try
            {
                await _unitOfWork.EmployeeRepository.Delete(employeeDB.Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// Generates a unique file name
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        private string GenerateFileName(string fileName, Employee employeeDTO)
        {
            string guid = Guid.NewGuid().ToString();
            string documentName = $"{guid}{employeeDTO.Name}{employeeDTO.Surname}{fileName}";
            return documentName.Replace(" ", "");
        }

        /// <summary>
        /// Generates a unique file picture name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="employeeDTO"></param>
        /// <returns></returns>
        private string GeneratePictureFileName(string fileName, Employee employeeDTO)
        {
            string guid = Guid.NewGuid().ToString();
            string documentName = $"{guid}{employeeDTO.Name}{employeeDTO.Surname}{fileName}";
            return documentName.Replace(" ", "");
        }
    }
}
