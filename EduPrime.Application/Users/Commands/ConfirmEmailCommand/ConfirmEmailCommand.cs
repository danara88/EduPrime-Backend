using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Confirm email command
    /// </summary>
    /// <param name="confirmEmailDTO"></param>
    public record ConfirmEmailCommand(ConfirmEmailDTO confirmEmailDTO) : IRequest<ErrorOr<string>> { }
}
