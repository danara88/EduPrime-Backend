using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Delete student command
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.DeleteStudentsPermission)]
    public record DeleteStudentCommand(int id) : IRequest<ErrorOr<string>> { }
}
