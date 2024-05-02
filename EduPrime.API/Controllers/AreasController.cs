using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Areas.Commands;
using EduPrime.Application.Areas.Queries;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    public class AreasController : ApiController
    {
        private readonly ISender _mediator;

        public AreasController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that returns all areas
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/areas/get-areas")]
        [ResponseCache(CacheProfileName = "OneMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAreas()
        {
            var query = new GetAreasQuery();
            var getAreasResult = await _mediator.Send(query);
            var response = new ApiResponse<List<AreaDTO>>(getAreasResult);

            return Ok(response);
        }

        /// <summary>
        /// End point that gets an area by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/areas/get-area/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAreaById(int id)
        {
            var query = new GetAreaByIdQuery(id);
            var getAreaResult = await _mediator.Send(query);

            Func<AreaDTO, IActionResult> response = (areaDTO) => Ok(new ApiResponse<AreaDTO>(areaDTO));

            return getAreaResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that creates an area
        /// </summary>
        /// <param name="createAreaDTO"></param>
        [AuthorizeRoles(
            nameof(RoleTypeEnum.Primary),
            nameof(RoleTypeEnum.Admin),
            nameof(RoleTypeEnum.Standard))]
        [HttpPost("~/api/v1/areas/create-area")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateArea([FromBody] CreateAreaDTO createAreaDTO)
        {
            var command = new CreateAreaCommand(createAreaDTO);
            var createAreaResult = await _mediator.Send(command);

            Func<AreaDTO, IActionResult> response = (areaDTO) => Ok(new ApiResponse<AreaDTO>(areaDTO)
            {
                Status = StatusCodes.Status201Created,
            });

            return createAreaResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates an Area
        /// </summary>
        /// <param name="updateAreaDTO"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("~/api/v1/areas/update-area")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateArea([FromBody] UpdateAreaDTO updateAreaDTO)
        {
            var command = new UpdateAreaCommand(updateAreaDTO);
            var updateAreaResult = await _mediator.Send(command);

            Func<AreaDTO, IActionResult> response = (areaDTO) => Ok(new ApiResponse<AreaDTO>(areaDTO));

            return updateAreaResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes an Area
        /// </summary>
        /// <param name="id"></param>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("~/api/v1/areas/delete-area/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var command = new DeleteAreaCommand(id);
            var deleteAreaResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return deleteAreaResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that gets all areas with employees
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/areas/get-areas-with-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetAreasWithEmployees()
        {
            var query = new GetAreasWithEmployeesQuery();
            var getAreasWithEmployeesResult = await _mediator.Send(query);
            var response = new ApiResponse<List<AreaWithEmployeesDTO>>(getAreasWithEmployeesResult);

            return Ok(response);
        }
    }
}
