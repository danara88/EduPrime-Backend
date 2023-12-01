using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Login command
    /// </summary>
    /// <param name="loginUserDTO"></param>
    public record LoginCommand(LogInUserDTO logInUserDTO) : IRequest<AuthTokenDTO> { }
}
