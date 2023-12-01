using MediatR;
using Microsoft.AspNetCore.Mvc;

using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Roles.Commands;
using EduPrime.Application.Roles.Commands.DeleteRoleCommand;
using EduPrime.Application.Roles.Queries;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;

namespace EduPrime.Api.Controllers
{
    /// <summary>
    /// NOTE:
    /// If you want to update the name of a role, please talk to the DB administrator.
    /// </summary>
    [Route("api/roles/v2")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ISender _mediator;

        public RolesController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point to return all the roles
        /// </summary>
        /// <returns></returns>
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
        /// End point to get a role by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
            var response = new ApiResponse<RoleWithUsersDTO>(getRoleByIdResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a role.
        /// NOTE: Be sure to add your new role into the enum: RoleTypeEnum.
        /// </summary>
        /// <param name="createRoleDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
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
            var response = new ApiResponse<RoleDTO>(createRoleResult)
            {
                Status = StatusCodes.Status201Created
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update the assigned role of a user
        /// </summary>
        /// <param name="updateUserRoleDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
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
            var response = new ApiMessageResponse(updateUserRoleResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to delete a role.
        /// NOTE: Be carefull. It will delete on cascade.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
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
            var response = new ApiMessageResponse(deleteRoleResult);

            return Ok(response);
        }

    }
}
