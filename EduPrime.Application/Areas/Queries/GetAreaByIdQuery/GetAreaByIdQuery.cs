using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetAreaByIdQuery(int id) : IRequest<ErrorOr<AreaDTO>> { }
}
