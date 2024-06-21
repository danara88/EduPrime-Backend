using MediatR;
using EduPrime.Core.DTOs.Role;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get roles query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetRolesPermission)]
    public record GetRolesQuery() : IRequest<ErrorOr<List<RoleDTO>>> { }
}
