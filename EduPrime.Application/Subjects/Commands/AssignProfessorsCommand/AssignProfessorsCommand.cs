using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Assign professors to a subject command
    /// </summary>
    /// <param name="assignProfessorsDTO"></param>
    public record AssignProfessorsCommand(AssignProfessorsDTO assignProfessorsDTO) : IRequest<ErrorOr<string>> { }
}
