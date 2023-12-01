using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Delete user command
    /// </summary>
    /// <param name="id"></param>
    public record DeleteUserCommand(int id) : IRequest<string> { }
}
