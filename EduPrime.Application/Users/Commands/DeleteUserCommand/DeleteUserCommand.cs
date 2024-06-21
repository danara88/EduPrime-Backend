using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Delete user command
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.DeleteUsersPermission)]
    public record DeleteUserCommand(int id) : IRequest<ErrorOr<string>> { }
}
