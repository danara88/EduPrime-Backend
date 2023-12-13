using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Students.Commands;
using EduPrime.Application.Students.Queries;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.Api.Controllers
{
    [Route("api/students/v2")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ISender _mediator;

        public StudentsController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point to return all students
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-students")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetStudents([FromQuery] PaginationDTO paginationDTO)
        {
            var query = new GetStudentsQuery(paginationDTO);
            var getStudentsResult = await _mediator.Send(query);
            var response = new ApiResponse<List<StudentDTO>>(getStudentsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to get a student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var query = new GetStudentByIdQuery(id);
            var getStudentResult = await _mediator.Send(query);
            var response = new ApiResponse<StudentDTO>(getStudentResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a subject
        /// </summary>
        /// <param name="createStudentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-student")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDTO createStudentDTO)
        {
            var command = new CreateStudentCommand(createStudentDTO);
            var createStudentResult = await _mediator.Send(command);
            var response = new ApiResponse<StudentDTO>(createStudentResult)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to assign subjects to a student
        /// </summary>
        /// <param name="assignSubjectsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("assign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignSubjects([FromBody] AssignSubjectsDTO assignSubjectsDTO)
        {
            var command = new AssignSubjectsCommand(assignSubjectsDTO);
            var assignSubjectsResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(assignSubjectsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to upload a picture for a student
        /// </summary>
        /// <param name="uploadStudentFileDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-student-picture")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadStudentPicture([FromBody] UploadStudentFileDTO uploadStudentFileDTO)
        {
            var command = new UploadStudentPictureCommand(uploadStudentFileDTO);
            var uploadStudentPictureResult = await _mediator.Send(command);
            var response = new ApiResponse<StudentDTO>(uploadStudentPictureResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to unassign subjects from a student
        /// </summary>
        /// <param name="unassignSubjectsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("unassign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignSubjects([FromBody] UnassignSubjectsDTO unassignSubjectsDTO)
        {
            var command = new UnassignSubjectsCommand(unassignSubjectsDTO);
            var unassignSubjectsResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(unassignSubjectsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to update student assignment notes
        /// </summary>
        /// <param name="updateStudentAssignmentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-student-assignment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudentAssignment([FromBody] UpdateStudentAssignmentDTO updateStudentAssignmentDTO)
        {
            var command = new UpdateStudentAssignmentCommand(updateStudentAssignmentDTO);
            var updateStudentAssignmentResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(updateStudentAssignmentResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to update a student
        /// </summary>
        /// <param name="updateStudentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentDTO updateStudentDTO)
        {
            var command = new UpdateStudentCommand(updateStudentDTO);
            var updateStudentResult = await _mediator.Send(command);
            var response = new ApiResponse<StudentDTO>(updateStudentResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to delete a student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var command = new DeleteStudentCommand(id);
            var deleteStudentResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(deleteStudentResult);
            
            return Ok(response);
        }
    }
}
