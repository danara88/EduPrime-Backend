using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get students query
    /// </summary>
    /// <param name="paginationDTO"></param>
    public record GetStudentsQuery(PaginationDTO paginationDTO) : IRequest<List<StudentDTO>> { }
}
