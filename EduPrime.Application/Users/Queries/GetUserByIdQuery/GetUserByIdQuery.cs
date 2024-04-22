using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get user by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetUserByIdQuery(int id) : IRequest<ErrorOr<UserDTO>> { }
}
