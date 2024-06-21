using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Delete professor command
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.DeleteProfessorsPermission)]
    public record DeleteProfessorCommand(int id) : IRequest<ErrorOr<string>> { }
}
