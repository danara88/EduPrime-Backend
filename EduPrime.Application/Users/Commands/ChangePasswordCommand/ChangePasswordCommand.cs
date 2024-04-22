using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Change password DTO
    /// </summary>
    /// <param name="changePasswordDTO"></param>
    public record ChangePasswordCommand(ChangePasswordDTO changePasswordDTO) : IRequest<ErrorOr<string>> { }
}
