using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Change password DTO
    /// </summary>
    /// <param name="changePasswordDTO"></param>
    public record ChangePasswordCommand(ChangePasswordDTO changePasswordDTO) : IRequest<string> { }
}
