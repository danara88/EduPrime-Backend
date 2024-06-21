using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Unassign professors from a subject command
    /// </summary>
    /// <param name="unassignProfessorsDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateSubjectsPermission)]
    public record UnassignProfessorsCommand(UnassignProfessorsDTO unassignProfessorsDTO) : IRequest<ErrorOr<string>> { }
}
