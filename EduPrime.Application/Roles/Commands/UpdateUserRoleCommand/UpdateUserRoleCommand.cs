using EduPrime.Core.DTOs.Role;
using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Update user role command
    /// </summary>
    /// <param name="updateUserRole"></param>
    public record UpdateUserRoleCommand(UpdateUserRoleDTO updateUserRoleDTO) : IRequest<string> { }
}
