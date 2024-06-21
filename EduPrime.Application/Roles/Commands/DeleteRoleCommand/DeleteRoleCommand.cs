using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Roles.Commands.DeleteRoleCommand
{
    /// <summary>
    /// Delete role command
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.DeleteRolesPermission)]
    public record DeleteRoleCommand(int id) : IRequest<ErrorOr<string>> { }
}
