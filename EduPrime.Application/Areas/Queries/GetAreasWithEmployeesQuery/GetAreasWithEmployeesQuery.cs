using EduPrime.Core.DTOs.Area;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get areas with employees query
    /// </summary>
    public record GetAreasWithEmployeesQuery() : IRequest<List<AreaWithEmployeesDTO>> { }
}
