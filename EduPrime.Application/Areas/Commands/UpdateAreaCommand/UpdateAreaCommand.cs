using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Update area command
    /// </summary>
    /// <param name="UpdateAreaDTO"></param>
    public record UpdateAreaCommand(UpdateAreaDTO updateAreaDTO) : IRequest<ErrorOr<AreaDTO>> { }
}
