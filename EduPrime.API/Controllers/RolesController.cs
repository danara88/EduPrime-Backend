using MediatR;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Roles.Commands;
using EduPrime.Application.Roles.Commands.DeleteRoleCommand;
using EduPrime.Application.Roles.Queries;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Enums;

namespace EduPrime.Api.Controllers
{
    /// <summary>
    /// NOTE:
    /// If you want to update the name of a role, please talk to the DB administrator.
    /// </summary>
    [Route("api/roles/v2")]
    [ApiController]
    public class RolesController : ApiController
    {
        private readonly ISender _mediator;

        public RolesController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that returns all the roles
        /// </summary>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-roles")]
        [ResponseCache(CacheProfileName = "OneMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetRoles()
        {
            var query = new GetRolesQuery();
            var getRolesResult = await _mediator.Send(query);
            var response = new ApiResponse<List<RoleDTO>>(getRolesResult);

            return Ok(response);
        }

        /// <summary>
        /// End point that gets a role by id
        /// </summary>
        /// <param name="id"></param>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-role/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var query = new GetRoleByIdQuery(id);
            var getRoleByIdResult = await _mediator.Send(query);

            Func<RoleWithUsersDTO, IActionResult> response = (roleWithUsersDTO) => Ok(new ApiResponse<RoleWithUsersDTO>(roleWithUsersDTO));

            return getRoleByIdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that creates a role.
        /// NOTE: Be sure to add your new role into the enum: RoleTypeEnum.
        /// </summary>
        /// <param name="createRoleDTO"></param>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPost("create-role")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleDTO createRoleDTO)
        {
            var command = new CreateRoleCommand(createRoleDTO);
            var createRoleResult = await _mediator.Send(command);

            Func<RoleDTO, IActionResult> response = (roleDTO) => Ok(new ApiResponse<RoleDTO>(roleDTO)
            {
                Status = StatusCodes.Status201Created
            });

            return createRoleResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates the assigned role of a user
        /// </summary>
        /// <param name="updateUserRoleDTO"></param>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPut("update-user-role")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUserRole([FromBody] UpdateUserRoleDTO updateUserRoleDTO)
        {
            var command = new UpdateUserRoleCommand(updateUserRoleDTO);
            var updateUserRoleResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return updateUserRoleResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes a role.
        /// NOTE: Be carefull. It will delete on cascade.
        /// </summary>
        /// <param name="id"></param>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpDelete("delete-role/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var command = new DeleteRoleCommand(id);
            var deleteRoleResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return deleteRoleResult.Match(
                response,
                Problem
            );
        }

    }
}
