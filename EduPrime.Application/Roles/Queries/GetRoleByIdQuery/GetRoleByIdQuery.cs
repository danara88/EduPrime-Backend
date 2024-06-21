using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Role;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get role by id query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetRolesPermission)]
    public record GetRoleByIdQuery(int Id) : IRequest<ErrorOr<RoleWithUsersDTO>> { }
}
