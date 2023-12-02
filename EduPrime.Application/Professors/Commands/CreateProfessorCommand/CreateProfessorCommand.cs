using EduPrime.Core.DTOs.Professor;
using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Create professor command
    /// </summary>
    /// <param name="createProfessorDTO"></param>
    public record CreateProfessorCommand(CreateProfessorDTO createProfessorDTO) : IRequest<ProfessorDTO> { }
}
