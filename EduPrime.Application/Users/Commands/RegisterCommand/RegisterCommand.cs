using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands.RegisterCommand
{
    /// <summary>
    /// Register command
    /// </summary>
    /// <param name="registerUserDTO"></param>
    public record RegisterCommand(RegisterUserDTO registerUserDTO) : IRequest<ErrorOr<UserDTO>> { }
}
