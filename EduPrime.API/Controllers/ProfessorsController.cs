using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Professors.Commands;
using EduPrime.Application.Professors.Queries;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.Api.Controllers
{
    [Route("api/professors/v2")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly ISender _mediator;

        public ProfessorsController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point to return all professors
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetProfessors()
        {
            var query = new GetProfessorsQuery();
            var getProfessorsResult = await _mediator.Send(query);
            var response = new ApiResponse<List<ProfessorDTO>>(getProfessorsResult);

            return Ok(response);
        }


        /// <summary>
        /// End point to get an employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProfessorById(int id)
        {
            var query = new GetProfessorByIdQuery(id);
            var getProfessorByIdResult = await _mediator.Send(query);
            var response = new ApiResponse<ProfessorDTO>(getProfessorByIdResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a professor
        /// </summary>
        /// <param name="createProfessorDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-professor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProfessor([FromBody] CreateProfessorDTO createProfessorDTO)
        {
            var command = new CreateProfessorCommand(createProfessorDTO);
            var createProfessorResult = await _mediator.Send(command);
            var response = new ApiResponse<ProfessorDTO>(createProfessorResult)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update a professor
        /// </summary>
        /// <param name="updateProfessorDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-professor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProfessor([FromBody] UpdateProfessorDTO updateProfessorDTO)
        {
            var command = new UpdateProfessorCommand(updateProfessorDTO);
            var updateProfessorResult = await _mediator.Send(command);
            var response = new ApiResponse<ProfessorDTO>(updateProfessorResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to delete a professor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProfessor(int id) 
        {
            var command = new DeleteProfessorCommand(id);
            var deleteProfessorResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(deleteProfessorResult);

            return Ok(response);
        }
    }
}
