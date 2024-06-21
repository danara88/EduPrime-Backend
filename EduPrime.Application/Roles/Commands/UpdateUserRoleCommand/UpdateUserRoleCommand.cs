using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Role;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Update user role command
    /// </summary>
    /// <param name="updateUserRole"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateRolesPermission)]
    public record UpdateUserRoleCommand(UpdateUserRoleDTO updateUserRoleDTO) : IRequest<ErrorOr<string>> { }
}
