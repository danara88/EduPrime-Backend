using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Create student command
    /// </summary>
    /// <param name="createStudentDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateStudentsPermission)]
    public record CreateStudentCommand(CreateStudentDTO createStudentDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
