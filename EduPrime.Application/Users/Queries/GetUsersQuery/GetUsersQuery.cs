using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Permissions.Consts;
using MediatR;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get users query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetUsersPermission)]
    public record GetUsersQuery() : IRequest<List<UserDTO>> { }
}
