using AutoMapper;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using EduPrime.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.API.Controllers
{
    [Route("api/employees/v1")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmployeeRepositoryService _employeeRepositoryService;
        private readonly IMapper _mapper;

        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper, IEmployeeRepositoryService employeeService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _employeeRepositoryService = employeeService;
        }

        /// <summary>
        /// End point to return all employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
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
        [HttpGet("get-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        [HttpPost("create-employee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO createEmployeeDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }
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
        /// End point to update an employee
        /// </summary>
        /// <param name="updateEmployeeDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpPut("update-employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDTO updateEmployeeDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(updateEmployeeDTO.Id);
            if (employeeDB is null)
            {
                throw new BadRequestException($"The employee with id {updateEmployeeDTO.Id} does not exist.");
            }

            employeeDB = _mapper.Map(updateEmployeeDTO, employeeDB);
            employeeDB.UpdatedOn = DateTime.Now;
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
        [HttpDelete("delete-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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
                _unitOfWork.EmployeeRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }
    }
}
