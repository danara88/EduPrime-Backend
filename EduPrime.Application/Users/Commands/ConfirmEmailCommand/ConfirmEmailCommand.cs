using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Confirm email command
    /// </summary>
    /// <param name="confirmEmailDTO"></param>
    public record ConfirmEmailCommand(ConfirmEmailDTO confirmEmailDTO) : IRequest<string> { }
}
