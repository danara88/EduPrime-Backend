using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Create student command
    /// </summary>
    /// <param name="createStudentDTO"></param>
    public record CreateStudentCommand(CreateStudentDTO createStudentDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
