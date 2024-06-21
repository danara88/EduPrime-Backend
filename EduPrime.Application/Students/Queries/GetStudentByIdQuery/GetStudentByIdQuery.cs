using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get student by id query
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetStudentsPermission)]
    public record GetStudentByIdQuery(int id) : IRequest<ErrorOr<StudentDTO>> { }
}
