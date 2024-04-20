using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Professor;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Update professor command
    /// </summary>
    /// <param name="updateProfessorDTO"></param>
    public record UpdateProfessorCommand(UpdateProfessorDTO updateProfessorDTO) : IRequest<ErrorOr<ProfessorDTO>> { }
}
