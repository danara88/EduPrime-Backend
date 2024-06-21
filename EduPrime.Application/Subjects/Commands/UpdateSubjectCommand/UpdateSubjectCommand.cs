using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Update subject command
    /// </summary>
    /// <param name="updateSubjectDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateSubjectsPermission)]
    public record UpdateSubjectCommand(UpdateSubjectDTO updateSubjectDTO) : IRequest<ErrorOr<string>> { }
}
