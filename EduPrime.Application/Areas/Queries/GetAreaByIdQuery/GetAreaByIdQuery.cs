using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area by id query
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetAreasPermission)]
    public record GetAreaByIdQuery(int id) : IRequest<ErrorOr<AreaDTO>> { }
}
