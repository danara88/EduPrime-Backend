using EduPrime.Core.DTOs.Area;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Update area command
    /// </summary>
    /// <param name="UpdateAreaDTO"></param>
    public record UpdateAreaCommand(UpdateAreaDTO updateAreaDTO) : IRequest<AreaDTO> { }
}
