using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Role;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Create role command
    /// </summary>
    /// <param name="createRoleDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateRolesPermission)]
    public record CreateRoleCommand(CreateRoleDTO createRoleDTO) : IRequest<ErrorOr<RoleDTO>> { }
}
