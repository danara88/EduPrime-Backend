using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subject by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetSubjectByIdQuery(int id) : IRequest<ErrorOr<SubjectDTO>> { }
}
