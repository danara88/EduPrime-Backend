using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student subject assignment command
    /// </summary>
    /// <param name="updateStudentAssignmentDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateStudentsPermission)]
    public record UpdateStudentAssignmentCommand(UpdateStudentAssignmentDTO updateStudentAssignmentDTO) : IRequest<ErrorOr<string>> { }

}
