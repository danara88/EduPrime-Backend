using EduPrime.Core.DTOs.User;
using MediatR;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get users query
    /// </summary>
    public record GetUsersQuery() : IRequest<List<UserDTO>> { }
}
