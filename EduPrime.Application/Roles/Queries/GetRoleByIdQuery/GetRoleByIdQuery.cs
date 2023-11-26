using EduPrime.Core.DTOs.Role;
using MediatR;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get role by id query
    /// </summary>
    public record GetRoleByIdQuery(int Id) : IRequest<RoleWithUsersDTO> { }
}
