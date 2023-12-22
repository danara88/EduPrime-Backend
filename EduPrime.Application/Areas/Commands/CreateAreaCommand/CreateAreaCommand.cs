using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Create area command
    /// </summary>
    /// <param name="createAreaDTO"></param>
    public record CreateAreaCommand(CreateAreaDTO createAreaDTO) : IRequest<ErrorOr<AreaDTO>> { }
}
