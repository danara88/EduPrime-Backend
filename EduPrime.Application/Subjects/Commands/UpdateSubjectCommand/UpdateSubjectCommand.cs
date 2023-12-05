using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Update subject command
    /// </summary>
    /// <param name="updateSubjectDTO"></param>
    public record UpdateSubjectCommand(UpdateSubjectDTO updateSubjectDTO) : IRequest<string> { }
}
