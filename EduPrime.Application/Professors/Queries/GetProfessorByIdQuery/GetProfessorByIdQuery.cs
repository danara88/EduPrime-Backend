using EduPrime.Core.DTOs.Professor;
using MediatR;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professor by id
    /// </summary>
    /// <param name="id"></param>
    public record GetProfessorByIdQuery(int id) : IRequest<ProfessorDTO> { }
}
