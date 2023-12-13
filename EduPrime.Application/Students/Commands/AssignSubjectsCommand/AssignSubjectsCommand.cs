using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Assign subjects to a student command
    /// </summary>
    /// <param name="assignSubjectsDTO"></param>
    public record AssignSubjectsCommand(AssignSubjectsDTO assignSubjectsDTO) : IRequest<string> { }
}
