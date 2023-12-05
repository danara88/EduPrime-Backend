using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Unassign professors from a subject command
    /// </summary>
    /// <param name="unassignProfessorsDTO"></param>
    public record UnassignProfessorsCommand(UnassignProfessorsDTO unassignProfessorsDTO) : IRequest<string> { }
}
