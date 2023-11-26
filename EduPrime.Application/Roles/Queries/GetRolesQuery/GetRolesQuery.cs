using EduPrime.Core.DTOs.Role;
using MediatR;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get roles query
    /// </summary>
    public record GetRolesQuery() : IRequest<List<RoleDTO>> { }
}
