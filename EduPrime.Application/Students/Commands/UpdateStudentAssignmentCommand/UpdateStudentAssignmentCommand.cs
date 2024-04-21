using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student subject assignment command
    /// </summary>
    /// <param name="updateStudentAssignmentDTO"></param>
    public record UpdateStudentAssignmentCommand(UpdateStudentAssignmentDTO updateStudentAssignmentDTO) : IRequest<ErrorOr<string>> { }

}
