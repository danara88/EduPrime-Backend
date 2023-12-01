using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Update user command
    /// </summary>
    /// <param name="updateUserDTO"></param>
    public record UpdateUserCommand(UpdateUserDTO updateUserDTO) : IRequest<UserDTO> { }
}
