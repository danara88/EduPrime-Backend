using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Create area command
    /// </summary>
    /// <param name="createAreaDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateAreasPermission)]
    public record CreateAreaCommand(CreateAreaDTO createAreaDTO) : IRequest<ErrorOr<AreaDTO>> { }
}
