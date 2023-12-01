using MediatR;
using Microsoft.AspNetCore.Mvc;

using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Users.Commands;
using EduPrime.Application.Users.Commands.RegisterCommand;
using EduPrime.Application.Users.Queries;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;

namespace EduPrime.Api.Controllers
{
    [Route("api/users/v2")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ISender _mediator;

        public UsersController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point to register a user
        /// </summary>
        /// <param name="registerUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register(RegisterUserDTO registerUserDTO)
        {
            var command = new RegisterCommand(registerUserDTO);
            var registerResult = await _mediator.Send(command);
            var response = new ApiResponse<UserDTO>(registerResult);
            
            return Ok(response);
        }

        /// <summary>
        /// End point to login a user
        /// </summary>
        /// <param name="logInUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [HttpPost("login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> LogIn(LogInUserDTO logInUserDTO)
        {
            var command = new LoginCommand(logInUserDTO);
            var loginResult = await _mediator.Send(command);
            var response = new ApiResponse<AuthTokenDTO>(loginResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to confirm user's email
        /// </summary>
        /// <param name="confirmEmailDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpGet("confirm-email")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailDTO confirmEmailDTO)
        {
            var command = new ConfirmEmailCommand(confirmEmailDTO);
            var confirmEmailResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(confirmEmailResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to send recovery password email
        /// </summary>
        /// <param name="recoveryPasswordDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpPost("recovery-password")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RecoveryPassword([FromBody] RecoveryPasswordDTO recoveryPasswordDTO)
        {
            var command = new RecoveryPasswordCommand(recoveryPasswordDTO);
            var recoveryPassowrdResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(recoveryPassowrdResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to change user password
        /// </summary>
        /// <param name="changePasswordDTO"></param>
        /// <returns></returns>
        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            var command = new ChangePasswordCommand(changePasswordDTO);
            var changePasswordResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(changePasswordResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-users")]
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUsers()
        {
            var query = new GetUsersQuery();
            var getUsersResult = await _mediator.Send(query);
            var response = new ApiResponse<List<UserDTO>>(getUsersResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to get a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(int id)
        {
            var query = new GetUserByIdQuery(id);
            var getUserByIdResult = await _mediator.Send(query);
            var response = new ApiResponse<UserDTO>(getUserByIdResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to update a user
        /// </summary>
        /// <param name="updateUserDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPut("update-user")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDTO updateUserDTO)
        {
            var command = new UpdateUserCommand(updateUserDTO);
            var updateUserResult = await _mediator.Send(command);
            var response = new ApiResponse<UserDTO>(updateUserResult);

            return Ok(response);
        }

        /// <summary>
        /// End point to delete a user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpDelete("delete-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var command = new DeleteUserCommand(id);
            var deleteUserResult = await _mediator.Send(command);
            var response = new ApiMessageResponse(deleteUserResult);

            return Ok(response);
        }
    }
}
