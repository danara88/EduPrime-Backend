using ErrorOr;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Delete student command
    /// </summary>
    public record DeleteStudentCommand(int id) : IRequest<ErrorOr<string>> { }
}
