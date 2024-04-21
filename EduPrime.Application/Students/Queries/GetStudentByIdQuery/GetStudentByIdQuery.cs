using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get student by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetStudentByIdQuery(int id) : IRequest<ErrorOr<StudentDTO>> { }
}
