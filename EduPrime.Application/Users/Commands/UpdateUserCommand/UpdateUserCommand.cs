using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Update user command
    /// </summary>
    /// <param name="updateUserDTO"></param>
    public record UpdateUserCommand(UpdateUserDTO updateUserDTO) : IRequest<ErrorOr<UserDTO>> { }
}
