using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Unassign subjects from a student command
    /// </summary>
    /// <param name="unassignSubjectsDTO"></param>
    public record UnassignSubjectsCommand(UnassignSubjectsDTO unassignSubjectsDTO) : IRequest<string> { }
}
