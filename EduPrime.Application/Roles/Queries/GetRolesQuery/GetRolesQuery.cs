using MediatR;
using EduPrime.Core.DTOs.Role;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get roles query
    /// </summary>
    public record GetRolesQuery() : IRequest<List<RoleDTO>> { }
}
