using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Update subject command
    /// </summary>
    /// <param name="updateSubjectDTO"></param>
    public record UpdateSubjectCommand(UpdateSubjectDTO updateSubjectDTO) : IRequest<ErrorOr<string>> { }
}
