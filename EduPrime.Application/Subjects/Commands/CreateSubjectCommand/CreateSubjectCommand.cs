using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Create subject command
    /// </summary>
    /// <param name="createSubjectDTO"></param>
    public record CreateSubjectCommand(CreateSubjectDTO createSubjectDTO) : IRequest<ErrorOr<string>> { }
}
