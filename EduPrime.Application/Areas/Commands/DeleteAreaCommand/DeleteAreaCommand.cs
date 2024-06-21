using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Delete area command
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.DeleteAreasPermission)]
    public record DeleteAreaCommand(int id) : IRequest<ErrorOr<string>> { }
}
