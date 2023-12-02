using EduPrime.Core.DTOs.Professor;
using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Update professor command
    /// </summary>
    /// <param name="updateProfessorDTO"></param>
    public record UpdateProfessorCommand(UpdateProfessorDTO updateProfessorDTO) : IRequest<ProfessorDTO> { }
}
