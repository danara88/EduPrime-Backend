using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Unassign subjects from a student command
    /// </summary>
    /// <param name="unassignSubjectsDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateStudentsPermission)]
    public record UnassignSubjectsCommand(UnassignSubjectsDTO unassignSubjectsDTO) : IRequest<ErrorOr<string>> { }
}
