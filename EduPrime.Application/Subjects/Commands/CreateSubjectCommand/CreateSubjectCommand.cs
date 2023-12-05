using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Create subject command
    /// </summary>
    /// <param name="createSubjectDTO"></param>
    public record CreateSubjectCommand(CreateSubjectDTO createSubjectDTO) : IRequest<string> { }
}
