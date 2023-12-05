using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Delete subject command
    /// </summary>
    /// <param name="id"></param>
    public record DeleteSubjectCommand(int id) : IRequest<string> { }
}
