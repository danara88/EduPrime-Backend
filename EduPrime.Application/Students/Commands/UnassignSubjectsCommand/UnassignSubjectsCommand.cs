using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Unassign subjects from a student command
    /// </summary>
    /// <param name="unassignSubjectsDTO"></param>
    public record UnassignSubjectsCommand(UnassignSubjectsDTO unassignSubjectsDTO) : IRequest<ErrorOr<string>> { }
}
