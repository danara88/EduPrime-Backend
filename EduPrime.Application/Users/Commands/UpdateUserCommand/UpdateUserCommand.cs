using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Update user command
    /// </summary>
    /// <param name="updateUserDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateUsersPermission)]
    public record UpdateUserCommand(UpdateUserDTO updateUserDTO) : IRequest<ErrorOr<UserDTO>> { }
}
