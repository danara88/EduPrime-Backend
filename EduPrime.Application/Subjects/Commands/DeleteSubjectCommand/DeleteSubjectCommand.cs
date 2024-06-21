using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Delete subject command
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.DeleteSubjectsPermission)]
    public record DeleteSubjectCommand(int id) : IRequest<ErrorOr<string>> { }
}
