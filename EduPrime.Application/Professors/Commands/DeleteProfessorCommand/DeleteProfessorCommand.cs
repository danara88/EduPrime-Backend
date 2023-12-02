using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Delete professor command
    /// </summary>
    /// <param name="id"></param>
    public record DeleteProfessorCommand(int id) : IRequest<string> { }
}
