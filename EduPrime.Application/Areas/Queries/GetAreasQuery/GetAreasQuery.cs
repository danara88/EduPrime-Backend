using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Permissions.Consts;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetAreasPermission)]
    public record GetAreasQuery() : IRequest<List<AreaDTO>> {}
}
