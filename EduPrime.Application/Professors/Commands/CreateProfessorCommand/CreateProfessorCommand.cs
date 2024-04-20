using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Professor;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Create professor command
    /// </summary>
    /// <param name="createProfessorDTO"></param>
    public record CreateProfessorCommand(CreateProfessorDTO createProfessorDTO) : IRequest<ErrorOr<ProfessorDTO>> { }
}
