using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Response;
using EduPrime.Application.Professors.Commands;
using EduPrime.Application.Professors.Queries;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    public class ProfessorsController : ApiController
    {
        private readonly ISender _mediator;

        public ProfessorsController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that returns all professors
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/professors/get-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetProfessors()
        {
            var query = new GetProfessorsQuery();
            var getProfessorsResult = await _mediator.Send(query);

            Func<List<ProfessorDTO>, IActionResult> response = (professorsDTO) =>
                Ok(new ApiResponse<List<ProfessorDTO>>(professorsDTO));

            return getProfessorsResult.Match(
                response,
                Problem
            );
        }


        /// <summary>
        /// End point that gets an employee by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/professors/get-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProfessorById(int id)
        {
            var query = new GetProfessorByIdQuery(id);
            var getProfessorByIdResult = await _mediator.Send(query);

            Func<ProfessorDTO, IActionResult> response =
                (professorDTO) => Ok(new ApiResponse<ProfessorDTO>(professorDTO));

            return getProfessorByIdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that creates a professor
        /// </summary>
        /// <param name="createProfessorDTO"></param>
        [Authorize]
        [HttpPost("~/api/v1/professors/create-professor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProfessor([FromBody] CreateProfessorDTO createProfessorDTO)
        {
            var command = new CreateProfessorCommand(createProfessorDTO);
            var createProfessorResult = await _mediator.Send(command);

            Func<ProfessorDTO, IActionResult> response = (professorDTO) => Ok(new ApiResponse<ProfessorDTO>(professorDTO)
            {
                Status = StatusCodes.Status201Created,
            });

            return createProfessorResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates a professor
        /// </summary>
        /// <param name="updateProfessorDTO"></param>
        [Authorize]
        [HttpPut("~/api/v1/professors/update-professor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProfessor([FromBody] UpdateProfessorDTO updateProfessorDTO)
        {
            var command = new UpdateProfessorCommand(updateProfessorDTO);
            var updateProfessorResult = await _mediator.Send(command);

            Func<ProfessorDTO, IActionResult> response = (professorDTO) =>
                Ok(new ApiResponse<ProfessorDTO>(professorDTO));

            return updateProfessorResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes a professor by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpDelete("~/api/v1/professors/delete-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProfessor(int id)
        {
            var command = new DeleteProfessorCommand(id);
            var deleteProfessorResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) =>
                Ok(new ApiMessageResponse(message));

            return deleteProfessorResult.Match(
                response,
                Problem
            );
        }
    }
}
