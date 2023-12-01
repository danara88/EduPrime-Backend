using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands.RegisterCommand
{
    /// <summary>
    /// Register command
    /// </summary>
    /// <param name="registerUserDTO"></param>
    public record RegisterCommand(RegisterUserDTO registerUserDTO) : IRequest<UserDTO> { }
}
