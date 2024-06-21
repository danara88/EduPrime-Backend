using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Update area command
    /// </summary>
    /// <param name="UpdateAreaDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateAreasPermission)]
    public record UpdateAreaCommand(UpdateAreaDTO updateAreaDTO) : IRequest<ErrorOr<AreaDTO>> { }
}
