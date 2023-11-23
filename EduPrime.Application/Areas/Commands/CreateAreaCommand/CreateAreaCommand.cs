using EduPrime.Core.DTOs.Area;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Create area command
    /// </summary>
    /// <param name="createAreaDTO"></param>
    public record CreateAreaCommand(CreateAreaDTO createAreaDTO) : IRequest<AreaDTO> { }
}
