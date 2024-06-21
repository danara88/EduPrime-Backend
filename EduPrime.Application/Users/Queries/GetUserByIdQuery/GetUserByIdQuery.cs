using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get user by id query
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetUsersPermission)]
    public record GetUserByIdQuery(int id) : IRequest<ErrorOr<UserDTO>> { }
}
