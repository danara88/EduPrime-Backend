using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Upload student picture command
    /// </summary>
    /// <param name="uploadStudentFileDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateStudentsPermission)]
    public record UploadStudentPictureCommand(UploadStudentFileDTO uploadStudentFileDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
