using EduPrime.Core.DTOs.Area;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area query
    /// </summary>
    public record GetAreasQuery() : IRequest<AreaDTO> {}
}
