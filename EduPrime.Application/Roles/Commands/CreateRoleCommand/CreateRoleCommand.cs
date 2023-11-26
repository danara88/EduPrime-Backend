using EduPrime.Core.DTOs.Role;
using MediatR;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Create role command
    /// </summary>
    /// <param name="createRoleDTO"></param>
    public record CreateRoleCommand(CreateRoleDTO createRoleDTO) : IRequest<RoleDTO> { }
}
