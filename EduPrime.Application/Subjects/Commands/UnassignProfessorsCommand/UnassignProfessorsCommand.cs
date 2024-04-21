using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Unassign professors from a subject command
    /// </summary>
    /// <param name="unassignProfessorsDTO"></param>
    public record UnassignProfessorsCommand(UnassignProfessorsDTO unassignProfessorsDTO) : IRequest<ErrorOr<string>> { }
}
