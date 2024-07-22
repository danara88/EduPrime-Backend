using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;
using EduPrime.Api.Controllers;
using EduPrime.Api.Response;
using EduPrime.Application.Areas.Commands;
using EduPrime.Application.Areas.Queries;
using EduPrime.Core.Areas;
using EduPrime.Core.DTOs.Area;

namespace EduPrime.Api.Tests.Unit.Controllers;

public class AreasControllerTests
{
    private readonly AreasController _sut;
    private readonly ISender _mediator = Substitute.For<ISender>();

    public AreasControllerTests()
    {
        _sut = new AreasController(_mediator);
    }

    [Fact]
    public async Task GetAreas_ShouldReturnApiResponseWithAreasDTO_WhenSuccessful()
    {
        // Arrange
        var areasDTO = new List<AreaDTO>();
        _mediator.Send(Arg.Any<GetAreasQuery>()).Returns(areasDTO);
        // Act
        var result = (ObjectResult) await _sut.GetAreas();
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should()
            .BeEquivalentTo(new ApiResponse<List<AreaDTO>>(areasDTO));
    }

    [Fact]
    public async Task GetAreaById_ShouldReturnApiResponseWithAreaDto_WhenAreaExists()
    {
        // Arrange
        var areaDTO = new AreaDTO();
        _mediator.Send(Arg.Any<GetAreaByIdQuery>())
            .Returns(areaDTO);
        // Act
        var result = (ObjectResult)await _sut.GetAreaById(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should()
            .BeEquivalentTo(new ApiResponse<AreaDTO>(areaDTO));
    }

    [Fact]
    public async Task GetAreaById_ShouldReturnNotFoundError_WhenAreaDoesNotExist()
    {
        // Arrange
        _mediator.Send(Arg.Any<GetAreaByIdQuery>())
            .Returns(AreaErrors.AreaWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.GetAreaById(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task CreateArea_ShouldReturnApiResponseWithAreaDto_WhenAreaIsCreated()
    {
        // Arrange
        var createAreaDTO = new CreateAreaDTO();
        var areaDTO = new AreaDTO();
        _mediator.Send(Arg.Any<CreateAreaCommand>()).Returns(areaDTO);
        // Act
        var result = (ObjectResult)await _sut.CreateArea(createAreaDTO);
        // Assert
        result.Value.Should()
            .BeEquivalentTo(
                new ApiResponse<AreaDTO>(areaDTO) { Status = StatusCodes.Status201Created });
    }

    [Fact]
    public async Task CreateArea_ShouldReturnConflictError_WhenAreaWithNameAlreadyExists()
    {
        // Arrange
        var createAreaDTO = new CreateAreaDTO();
        _mediator.Send(Arg.Any<CreateAreaCommand>())
            .Returns(AreaErrors.AreaWithNameAlreadyExists("test"));
        // Act
        var result = (ObjectResult)await _sut.CreateArea(createAreaDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status409Conflict);
    }

     [Fact]
    public async Task UpdateArea_ShouldReturnApiResponseWithAreaDto_WhenAreaExists()
    {
        // Arrange
        var updateAreaDTO = new UpdateAreaDTO();
        var areaDTO = new AreaDTO();
        _mediator.Send(Arg.Any<UpdateAreaCommand>())
            .Returns(areaDTO);
        // Act
        var result = (ObjectResult)await _sut.UpdateArea(updateAreaDTO);
        // Assert
        result.Value.Should()
            .BeEquivalentTo(
                new ApiResponse<AreaDTO>(areaDTO));
    }

    [Fact]
    public async Task UpdateArea_ShouldReturnNotFoundError_WhenAreaDoesNotExist()
    {
        // Arrange
         var updateAreaDTO = new UpdateAreaDTO();
        _mediator.Send(Arg.Any<UpdateAreaCommand>())
            .Returns(AreaErrors.AreaWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.UpdateArea(updateAreaDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task DeleteArea_ShouldReturnApiResponseWithMessage_WhenAreaExist()
    {
        // Arrange
        var mockMessage = "The resource has been deleted successfully";
        _mediator.Send(Arg.Any<DeleteAreaCommand>()).Returns(mockMessage);
        // Act
        var result = (ObjectResult)await _sut.DeleteArea(1);
        // Assert
        result.Value.Should().BeEquivalentTo(new ApiMessageResponse(mockMessage));
    }

     [Fact]
    public async Task DeleteArea_ShouldReturnNotFoundError_WhenAreaDoesNotExist()
    {
        // Arrange
        _mediator.Send(Arg.Any<DeleteAreaCommand>())
            .Returns(AreaErrors.AreaWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.DeleteArea(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task GetAreasWithEmployees_ShouldReturnApiResponseWithAreaWithEmployeesDto_WhenSuccessful()
    {
        // Arrange
        var areasWithEmployeesDTO = new List<AreaWithEmployeesDTO>();
        _mediator.Send(Arg.Any<GetAreasWithEmployeesQuery>()).Returns(areasWithEmployeesDTO);
        // Act
        var result = (ObjectResult)await _sut.GetAreasWithEmployees();
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should()
            .BeEquivalentTo(new ApiResponse<List<AreaWithEmployeesDTO>>(areasWithEmployeesDTO));
    }
}