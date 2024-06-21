using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Assign professors to a subject command
    /// </summary>
    /// <param name="assignProfessorsDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateSubjectsPermission)]
    public record AssignProfessorsCommand(AssignProfessorsDTO assignProfessorsDTO) : IRequest<ErrorOr<string>> { }
}
