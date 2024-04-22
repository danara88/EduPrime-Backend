using ErrorOr;
using MediatR;

namespace EduPrime.Application.Roles.Commands.DeleteRoleCommand
{
    /// <summary>
    /// Delete role command
    /// </summary>
    public record DeleteRoleCommand(int id) : IRequest<ErrorOr<string>> { }
}
