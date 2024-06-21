using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Response;
using EduPrime.Application.Subjects.Commands;
using EduPrime.Application.Subjects.Queries;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    public class SubjectsController : ApiController
    {
        private readonly ISender _mediator;

        public SubjectsController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point to return subjects paginated
        /// </summary>
        /// <param name="paginationDTO"></param>
        [Authorize]
        [HttpGet("~/api/v1/subjects/get-subjects")]
        [ResponseCache(CacheProfileName = "HalfMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetSubjects([FromQuery] PaginationDTO paginationDTO)
        {
            var query = new GetSubjectsQuery(paginationDTO);
            var getSubjectsResult = await _mediator.Send(query);

            Func<List<SubjectDTO>, IActionResult> response = (subjectsDTO) =>
                Ok(new ApiResponse<List<SubjectDTO>>(subjectsDTO));

            return getSubjectsResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to get a subject by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/subjects/get-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubjectById(int id)
        {
            var query = new GetSubjectByIdQuery(id);
            var getSubjectByIdResult = await _mediator.Send(query);

            Func<SubjectDTO, IActionResult> response = (subjectDTO) =>
                Ok(new ApiResponse<SubjectDTO>(subjectDTO));

            return getSubjectByIdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to crate a subject
        /// </summary>
        /// <param name="createSubjectDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/subjects/create-subject")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectDTO createSubjectDTO)
        {
            var command = new CreateSubjectCommand(createSubjectDTO);
            var createSubjectResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message)
            {
                Status = StatusCodes.Status201Created,
            });

            return createSubjectResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to update a subject
        /// </summary>
        /// <param name="updateSubjectDTO"></param>
        [Authorize]
        [HttpPut("~/api/v1/subjects/update-subject")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateSubject([FromBody] UpdateSubjectDTO updateSubjectDTO)
        {
            var command = new UpdateSubjectCommand(updateSubjectDTO);
            var updateSubjectResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return updateSubjectResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to unassign professors
        /// </summary>
        /// <param name="unassignProfessorsDTO"></param>
        [Authorize]
        [HttpPut("~/api/v1/subjects/unassign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignProfessors([FromBody] UnassignProfessorsDTO unassignProfessorsDTO)
        {
            var command = new UnassignProfessorsCommand(unassignProfessorsDTO);
            var unassignProfessorsResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return unassignProfessorsResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to assign professors
        /// </summary>
        /// <param name="assignProfessorsDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/subjects/assign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignProfessors([FromBody] AssignProfessorsDTO assignProfessorsDTO)
        {
            var command = new AssignProfessorsCommand(assignProfessorsDTO);
            var assignProfessorsResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return assignProfessorsResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point to delete a subject by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpDelete("~/api/v1/subjects/delete-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var command = new DeleteSubjectCommand(id);
            var deleteSubjectResult = await _mediator.Send(command);

             Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return deleteSubjectResult.Match(
                response,
                Problem
            );
        }
    }
}
