using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subjects query
    /// </summary>
    /// <param name="paginationDTO"></param>
    public record GetSubjectsQuery(PaginationDTO paginationDTO) : IRequest<List<SubjectDTO>> { }
}
