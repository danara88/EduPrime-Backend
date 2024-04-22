using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Role;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Create role command
    /// </summary>
    /// <param name="createRoleDTO"></param>
    public record CreateRoleCommand(CreateRoleDTO createRoleDTO) : IRequest<ErrorOr<RoleDTO>> { }
}
