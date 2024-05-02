using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Students.Commands;
using EduPrime.Application.Students.Queries;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    public class StudentsController : ApiController
    {
        private readonly ISender _mediator;

        public StudentsController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that returns all students
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/students/get-students")]
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
        /// End point that gets a student by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/students/get-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var query = new GetStudentByIdQuery(id);
            var getStudentResult = await _mediator.Send(query);

            Func<StudentDTO, IActionResult> response = (studentDTO) => Ok(new ApiResponse<StudentDTO>(studentDTO));

            return getStudentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that creates a subject
        /// </summary>
        /// <param name="createStudentDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("~/api/v1/students/create-student")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDTO createStudentDTO)
        {
            var command = new CreateStudentCommand(createStudentDTO);
            var createStudentResult = await _mediator.Send(command);

            Func<StudentDTO, IActionResult> response = (studentDTO) => Ok(new ApiResponse<StudentDTO>(studentDTO)
            {
                Status = StatusCodes.Status201Created,
            });

            return createStudentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that assigns subjects to a student
        /// </summary>
        /// <param name="assignSubjectsDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("~/api/v1/students/assign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignSubjects([FromBody] AssignSubjectsDTO assignSubjectsDTO)
        {
            var command = new AssignSubjectsCommand(assignSubjectsDTO);
            var assignSubjectsResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return assignSubjectsResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that uploads a picture for a student
        /// </summary>
        /// <param name="uploadStudentFileDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("~/api/v1/students/upload-student-picture")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadStudentPicture([FromBody] UploadStudentFileDTO uploadStudentFileDTO)
        {
            var command = new UploadStudentPictureCommand(uploadStudentFileDTO);
            var uploadStudentPictureResult = await _mediator.Send(command);

            Func<StudentDTO, IActionResult> response = (studentDTO) => Ok(new ApiResponse<StudentDTO>(studentDTO));

            return uploadStudentPictureResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that unassigns subjects from a student
        /// </summary>
        /// <param name="unassignSubjectsDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("~/api/v1/students/unassign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignSubjects([FromBody] UnassignSubjectsDTO unassignSubjectsDTO)
        {
            var command = new UnassignSubjectsCommand(unassignSubjectsDTO);
            var unassignSubjectsResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return unassignSubjectsResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates student assignment notes
        /// </summary>
        /// <param name="updateStudentAssignmentDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("~/api/v1/students/update-student-assignment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudentAssignment([FromBody] UpdateStudentAssignmentDTO updateStudentAssignmentDTO)
        {
            var command = new UpdateStudentAssignmentCommand(updateStudentAssignmentDTO);
            var updateStudentAssignmentResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return updateStudentAssignmentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates a student
        /// </summary>
        /// <param name="updateStudentDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("~/api/v1/students/update-student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentDTO updateStudentDTO)
        {
            var command = new UpdateStudentCommand(updateStudentDTO);
            var updateStudentResult = await _mediator.Send(command);

            Func<StudentDTO, IActionResult> response = (studentDTO) => Ok(new ApiResponse<StudentDTO>(studentDTO));

            return updateStudentResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes a student by id
        /// </summary>
        /// <param name="id"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("~/api/v1/students/delete-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var command = new DeleteStudentCommand(id);
            var deleteStudentResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return deleteStudentResult.Match(
                response,
                Problem
            );
        }
    }
}
