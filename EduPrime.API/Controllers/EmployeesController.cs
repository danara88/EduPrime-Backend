using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Employees.Commands;
using EduPrime.Application.Employees.Queries;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;

namespace EduPrime.Api.Controllers
{
    [Route("api/employees/v2")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ISender _mediator;

        public EmployeesController(ISender mediator)
        {
            _mediator = mediator;
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
            var query = new GetEmployeesQuery();
            var getEmployeesResult = await _mediator.Send(query);
            var response = new ApiResponse<List<EmployeeDTO>>(getEmployeesResult);

            return Ok(response);
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
            var query = new GetEmployeeByIdQuery(id);
            var getEmployeeByIdResult = await _mediator.Send(query);
            var response = new ApiResponse<EmployeeDTO>(getEmployeeByIdResult);

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
            var command = new CreateEmployeeCommand(createEmployeeDTO);
            var createEmployeeResult = await _mediator.Send(command);
            var response = new ApiResponse<EmployeeDTO>(createEmployeeResult)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to upload a RFC document to an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-employee-rfc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadRFCDocument([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO)
        {
            var command = new UploadRFCDocumentCommand(uploadEmployeeFileDTO);
            var uploadRFCDocumentResult = await _mediator.Send(command);
            var response = new ApiResponse<EmployeeDTO>(uploadRFCDocumentResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to upload a picture for an employee
        /// </summary>
        /// <param name="uploadEmployeeFileDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-employee-picture")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadEmployeePicture([FromBody] UploadEmployeeFileDTO uploadEmployeeFileDTO)
        {
            var command = new UploadEmployeePictureCommand(uploadEmployeeFileDTO);
            var uploadEmployeePictureResult = await _mediator.Send(command);
            var response = new ApiResponse<EmployeeDTO>(uploadEmployeePictureResult);

            return Ok(response);
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
        public async Task<IActionResult> DownloadRFCDocument(int employeeId)
        {
            var command = new DownloadRFCDocumentCommand(employeeId);
            var downloadRFCDocumentResult = await _mediator.Send(command);

            Response.Headers.Add("Content-Disposition", "attachment; filename=" + downloadRFCDocumentResult.employee.RfcDocument);
            return File(downloadRFCDocumentResult.stream, "application/octet-stream");
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
            var command = new UpdateEmployeeCommand(updateEmployeeDTO);
            var updateEmployeeResult = await _mediator.Send(command);
            var response = new ApiResponse<EmployeeDTO>(updateEmployeeResult);

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
            var command = new DeleteEmployeeCommand(id);
            var deleteEmployeeResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(deleteEmployeeResult);

            return Ok(response);
        }
    }
}
