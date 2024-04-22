using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Role;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Update user role command
    /// </summary>
    /// <param name="updateUserRole"></param>
    public record UpdateUserRoleCommand(UpdateUserRoleDTO updateUserRoleDTO) : IRequest<ErrorOr<string>> { }
}
