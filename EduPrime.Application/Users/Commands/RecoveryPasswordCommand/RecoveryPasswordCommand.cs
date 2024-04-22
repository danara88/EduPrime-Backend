using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Recovery password command
    /// </summary>
    /// <param name="recoveryPasswordDTO"></param>
    public record RecoveryPasswordCommand(RecoveryPasswordDTO recoveryPasswordDTO) : IRequest<ErrorOr<string>> { }
}
