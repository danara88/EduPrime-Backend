using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Delete area command
    /// </summary>
    /// <param name="id"></param>
    public record DeleteAreaCommand(int id) : IRequest<string> { }
}
