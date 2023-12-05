using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Assign professors to a subject command
    /// </summary>
    /// <param name="assignProfessorsDTO"></param>
    public record AssignProfessorsCommand(AssignProfessorsDTO assignProfessorsDTO) : IRequest<string> { }
}
