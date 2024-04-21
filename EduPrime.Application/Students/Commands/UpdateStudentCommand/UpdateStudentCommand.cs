using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student command
    /// </summary>
    /// <param name="updateStudentDTO"></param>
    public record UpdateStudentCommand(UpdateStudentDTO updateStudentDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
