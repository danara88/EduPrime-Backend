using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Assign subjects to a student command
    /// </summary>
    /// <param name="assignSubjectsDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateStudentsPermission)]
    public record AssignSubjectsCommand(AssignSubjectsDTO assignSubjectsDTO) : IRequest<ErrorOr<string>> { }
}
