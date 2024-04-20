using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Professor;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professor by id
    /// </summary>
    /// <param name="id"></param>
    public record GetProfessorByIdQuery(int id) : IRequest<ErrorOr<ProfessorDTO>> { }
}
