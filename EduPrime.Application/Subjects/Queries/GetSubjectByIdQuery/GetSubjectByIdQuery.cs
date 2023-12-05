using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subject by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetSubjectByIdQuery(int id) : IRequest<SubjectDTO> { }
}
