using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Create student command
    /// </summary>
    /// <param name="createStudentDTO"></param>
    public record CreateStudentCommand(CreateStudentDTO createStudentDTO) : IRequest<StudentDTO> { }
}
