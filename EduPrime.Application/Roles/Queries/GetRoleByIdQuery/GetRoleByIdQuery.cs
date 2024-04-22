using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Role;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get role by id query
    /// </summary>
    public record GetRoleByIdQuery(int Id) : IRequest<ErrorOr<RoleWithUsersDTO>> { }
}
