using EduPrime.Application.Areas.Commands;
using EduPrime.Core.DTOs.Area;

namespace TestCommon.Areas;

public static class AreaCommandFactory
{
    public static CreateAreaCommand CreateCreateAreaCommand(CreateAreaDTO createAreaDTO)
    {
        return new CreateAreaCommand(createAreaDTO);
    }
}
