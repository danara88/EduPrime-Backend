using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student command
    /// </summary>
    /// <param name="updateStudentDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateStudentsPermission)]
    public record UpdateStudentCommand(UpdateStudentDTO updateStudentDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
