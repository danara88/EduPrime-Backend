using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student command
    /// </summary>
    /// <param name="updateStudentDTO"></param>
    public record UpdateStudentCommand(UpdateStudentDTO updateStudentDTO) : IRequest<StudentDTO> { }
}
