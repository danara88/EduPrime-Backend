using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Login command
    /// </summary>
    /// <param name="loginUserDTO"></param>
    public record LoginCommand(LogInUserDTO logInUserDTO) : IRequest<ErrorOr<AuthTokenDTO>> { }
}
