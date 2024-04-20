using MediatR;
using EduPrime.Core.DTOs.Professor;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professors query
    /// </summary>
    public record GetProfessorsQuery() : IRequest<List<ProfessorDTO>> { }
}
