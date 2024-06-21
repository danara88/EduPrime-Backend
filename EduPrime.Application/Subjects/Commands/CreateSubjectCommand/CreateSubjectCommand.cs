using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Create subject command
    /// </summary>
    /// <param name="createSubjectDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateSubjectsPermission)]
    public record CreateSubjectCommand(CreateSubjectDTO createSubjectDTO) : IRequest<ErrorOr<string>> { }
}
