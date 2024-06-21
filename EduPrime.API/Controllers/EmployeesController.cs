using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Response;
using EduPrime.Application.Employees.Commands;
using EduPrime.Application.Employees.Queries;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly ISender _mediator;

        public EmployeesController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that returns all employees
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/employees/get-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetEmployees()
        {
            var query = new GetEmployeesQuery();
            var getEmployeesResult = await _mediator.Send(query);

            Func<List<EmployeeDTO>, IActionResult> response = (employeesDTO) =>
                Ok(new ApiResponse<List<EmployeeDTO>>(employeesDTO));

            return getEmployeesResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that gets an employee by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/employees/get-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var query = new GetEmployeeByIdQuery(id);
            var getEmployeeByIdResult = await _mediator.Send(query);

            Func<EmployeeDTO, IActionResult> response = (employeeDTO) =>
                Ok(new ApiResponse<EmployeeDTO>(employeeDTO));

            return getEmployeeByIdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that creates an employee
        /// </summary>
        /// <param name="createEmployeeDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/employees/create-employee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeDTO createEmployeeDTO)
        {
            var command = new CreateEmployeeCommand(createEmployeeDTO);
            var createEmployeeResult = await _mediator.Send(command);

            Func<EmployeeDTO, IActionResult> response = (employeeDTO) => Ok(new ApiResponse<EmployeeDTO>(employeeDTO)
            {
                Status = StatusCodes.Status201Created,
            });

            return createEmployeeResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that uploads a RFC document to an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/employees/upload-employee-rfc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadRFCDocument([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO)
        {
            var command = new UploadRFCDocumentCommand(uploadEmployeeFileDTO);
            var uploadRFCDocumentResult = await _mediator.Send(command);

            Func<EmployeeDTO, IActionResult> response = (employeeDTO) =>
                Ok(new ApiResponse<EmployeeDTO>(employeeDTO));

            return uploadRFCDocumentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that uploads a picture for an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/employees/upload-employee-picture")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadEmployeePicture([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO)
        {
            var command = new UploadEmployeePictureCommand(uploadEmployeeFileDTO);
            var uploadEmployeePictureResult = await _mediator.Send(command);

            Func<EmployeeDTO, IActionResult> response = (employeeDTO) =>
                Ok(new ApiResponse<EmployeeDTO>(employeeDTO));

            return uploadEmployeePictureResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that downloads the RFC document from an employee
        /// </summary>
        /// <param name="employeeId"></param>
        [Authorize]
        [HttpGet("~/api/v1/employees/download-employee-rfc/{employeeId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DownloadRFCDocument(int employeeId)
        {
            var command = new DownloadRFCDocumentCommand(employeeId);
            var downloadRFCDocumentResult = await _mediator.Send(command);

            Func<DownloadEmployeeRfcDTO, IActionResult> response = (downloadEmployeeRfcDTO) => {
                Response.Headers.Add("Content-Disposition", "attachment; filename=" + downloadEmployeeRfcDTO.employee.RfcDocument);
                return File(downloadEmployeeRfcDTO.stream, "application/octet-stream");
            };

            return downloadRFCDocumentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates an employee
        /// </summary>
        /// <param name="updateEmployeeDTO"></param>
        [Authorize]
        [HttpPut("~/api/v1/employees/update-employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeDTO updateEmployeeDTO)
        {
            var command = new UpdateEmployeeCommand(updateEmployeeDTO);
            var updateEmployeeResult = await _mediator.Send(command);

            Func<EmployeeDTO, IActionResult> response = (employeeDTO) =>
                Ok(new ApiResponse<EmployeeDTO>(employeeDTO));

            return updateEmployeeResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes an employee
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpDelete("~/api/v1/employees/delete-employee/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var command = new DeleteEmployeeCommand(id);
            var deleteEmployeeResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return deleteEmployeeResult.Match(
                response,
                Problem
            );
        }
    }
}
