using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Recovery password command
    /// </summary>
    /// <param name="recoveryPasswordDTO"></param>
    public record RecoveryPasswordCommand(RecoveryPasswordDTO recoveryPasswordDTO) : IRequest<string> { }
}
