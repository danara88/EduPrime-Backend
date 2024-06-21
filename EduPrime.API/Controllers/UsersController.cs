using MediatR;
using Microsoft.AspNetCore.Mvc;
using EduPrime.Api.Response;
using EduPrime.Application.Users.Commands;
using EduPrime.Application.Users.Queries;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Enums;
using Microsoft.AspNetCore.Authorization;

namespace EduPrime.Api.Controllers
{
    public class UsersController : ApiController
    {
        private readonly ISender _mediator;

        public UsersController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// End point that registers a user
        /// </summary>
        /// <param name="registerUserDTO"></param>
        [AllowAnonymous]
        [HttpPost("~/api/v1/users/register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register(RegisterUserDTO registerUserDTO)
        {
            var command = new RegisterCommand(registerUserDTO);
            var registerResult = await _mediator.Send(command);

            Func<UserDTO, IActionResult> response = (userDTO) => Ok(new ApiResponse<UserDTO>(userDTO));

            return registerResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that signs a user in
        /// </summary>
        /// <param name="logInUserDTO"></param>
        [AllowAnonymous]
        [HttpPost("~/api/v1/users/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> LogIn(LogInUserDTO logInUserDTO)
        {
            var command = new LoginCommand(logInUserDTO);
            var loginResult = await _mediator.Send(command);

            Func<AuthTokenDTO, IActionResult> response = (authTokenDTO) => Ok(new ApiResponse<AuthTokenDTO>(authTokenDTO));

            return loginResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that confirms user's email
        /// </summary>
        /// <param name="confirmEmailDTO"></param>
        [AllowAnonymous]
        [HttpGet("~/api/v1/users/confirm-email")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailDTO confirmEmailDTO)
        {
            var command = new ConfirmEmailCommand(confirmEmailDTO);
            var confirmEmailResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return confirmEmailResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that sends recovery password email
        /// </summary>
        /// <param name="recoveryPasswordDTO"></param>
        [AllowAnonymous]
        [HttpPost("~/api/v1/users/recovery-password")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RecoveryPassword([FromBody] RecoveryPasswordDTO recoveryPasswordDTO)
        {
            var command = new RecoveryPasswordCommand(recoveryPasswordDTO);
            var recoveryPassowrdResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return recoveryPassowrdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that changes user password
        /// </summary>
        /// <param name="changePasswordDTO"></param>
        [AllowAnonymous]
        [HttpPut("~/api/v1/users/change-password")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO changePasswordDTO)
        {
            var command = new ChangePasswordCommand(changePasswordDTO);
            var changePasswordResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return changePasswordResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that gets all users
        /// </summary>
        [Authorize]
        [HttpGet("~/api/v1/users/get-users")]
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
        /// End point that gets a user by id
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpGet("~/api/v1/users/get-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUserById(int id)
        {
            var query = new GetUserByIdQuery(id);
            var getUserByIdResult = await _mediator.Send(query);

            Func<UserDTO, IActionResult> response = (userDTO) => Ok(new ApiResponse<UserDTO>(userDTO));

            return getUserByIdResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that updates a user
        /// </summary>
        /// <param name="updateUserDTO"></param>
        [Authorize]
        [HttpPut("~/api/v1/users/update-user")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDTO updateUserDTO)
        {
            var command = new UpdateUserCommand(updateUserDTO);
            var updateUserResult = await _mediator.Send(command);

            Func<UserDTO, IActionResult> response = (userDTO) => Ok(new ApiResponse<UserDTO>(userDTO));

            return updateUserResult.Match(
                response,
                Problem
            );
        }

        /// <summary>
        /// End point that deletes a user
        /// </summary>
        /// <param name="id"></param>
        [Authorize]
        [HttpDelete("~/api/v1/users/delete-user/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var command = new DeleteUserCommand(id);
            var deleteUserResult = await _mediator.Send(command);

            Func<string, IActionResult> response = (message) => Ok(new ApiMessageResponse(message));

            return deleteUserResult.Match(
                response,
                Problem
            );
        }
    }
}
