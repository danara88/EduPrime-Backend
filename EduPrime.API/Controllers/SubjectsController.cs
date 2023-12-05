using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Subjects.Commands;
using EduPrime.Application.Subjects.Queries;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.Api.Controllers
{
    [Route("api/subjects/v2")]
    [ApiController]
    public class SubjectsController : ControllerBase
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
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-subjects")]
        [ResponseCache(CacheProfileName = "HalfMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetSubjects([FromQuery] PaginationDTO paginationDTO)
        {
            var query = new GetSubjectsQuery(paginationDTO);
            var getSubjectsResult = await _mediator.Send(query);
            var response = new ApiResponse<List<SubjectDTO>>(getSubjectsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to get a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubjectById(int id)
        {
            var query = new GetSubjectByIdQuery(id);
            var getSubjectByIdResult = await _mediator.Send(query);
            var response = new ApiResponse<SubjectDTO>(getSubjectByIdResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to crate a subject
        /// </summary>
        /// <param name="createSubjectDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-subject")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectDTO createSubjectDTO)
        {
            var command = new CreateSubjectCommand(createSubjectDTO);
            var createSubjectResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(createSubjectResult)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update a subject
        /// </summary>
        /// <param name="updateSubjectDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-subject")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateSubject([FromBody] UpdateSubjectDTO updateSubjectDTO)
        {
            var command = new UpdateSubjectCommand(updateSubjectDTO);
            var updateSubjectResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(updateSubjectResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to unassign professors
        /// </summary>
        /// <param name="unassignProfessorsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("unassign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignProfessors([FromBody] UnassignProfessorsDTO unassignProfessorsDTO)
        {
            var command = new UnassignProfessorsCommand(unassignProfessorsDTO);
            var unassignProfessorsResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(unassignProfessorsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to assign professors
        /// </summary>
        /// <param name="assignProfessorsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("assign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignProfessors([FromBody] AssignProfessorsDTO assignProfessorsDTO)
        {
            var command = new AssignProfessorsCommand(assignProfessorsDTO);
            var assignProfessorsResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(assignProfessorsResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to delete a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var command = new DeleteSubjectCommand(id);
            var deleteSubjectResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(deleteSubjectResult);

            return Ok(response);
        }
    }
}
