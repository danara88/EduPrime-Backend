using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;
using EduPrime.Api.Controllers;
using EduPrime.Api.Response;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Application.Employees.Queries;
using EduPrime.Core.Employees;
using EduPrime.Application.Employees.Commands;
using EduPrime.Core.Common;
using EduPrime.Core.Entities;

namespace EduPrime.Api.Tests.Unit.Controllers;

public class EmployeesControllerTests
{
    private readonly EmployeesController _sut;
    private readonly ISender _mediator = Substitute.For<ISender>();

    public EmployeesControllerTests()
    {
        _sut = new EmployeesController(_mediator);
    }

    [Fact]
    public async Task GetEmployees_ShouldReturnApiResponseWithEmployeesDTO_WhenSuccessful()
    {
        // Arrange
        var employeesDTO = new List<EmployeeDTO>();
        _mediator.Send(Arg.Any<GetEmployeesQuery>()).Returns(employeesDTO);
        // Act
        var result = (ObjectResult) await _sut.GetEmployees();
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should()
            .BeEquivalentTo(new ApiResponse<List<EmployeeDTO>>(employeesDTO));
    }

    [Fact]
    public async Task GetEmployeeById_ShouldReturnApiResponseWithEmployeeDto_WhenEmployeeExists()
    {
        // Arrange
        var employeeDTO = new EmployeeDTO();
        _mediator.Send(Arg.Any<GetEmployeeByIdQuery>())
            .Returns(employeeDTO);
        // Act
        var result = (ObjectResult)await _sut.GetEmployeeById(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should()
            .BeEquivalentTo(new ApiResponse<EmployeeDTO>(employeeDTO));
    }

    [Fact]
    public async Task GetEmployeeById_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
        _mediator.Send(Arg.Any<GetEmployeeByIdQuery>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.GetEmployeeById(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task CreateEmployee_ShouldReturnApiResponseWithEmployeeDto_WhenEmployeeIsCreated()
    {
        // Arrange
        var createEmployeeDTO = new CreateEmployeeDTO();
        var employeeDTO = new EmployeeDTO();
        _mediator.Send(Arg.Any<CreateEmployeeCommand>()).Returns(employeeDTO);
        // Act
        var result = (ObjectResult)await _sut.CreateEmployee(createEmployeeDTO);
        // Assert
        result.Value.Should()
            .BeEquivalentTo(
                new ApiResponse<EmployeeDTO>(employeeDTO) { Status = StatusCodes.Status201Created });
    }

    [Fact]
    public async Task CreateEmployee_ShouldReturnBadRequestError_WhenCreateEmployeeRequestIsInvalid()
    {
        // Arrange
        var createEmployeeDTO = new CreateEmployeeDTO();
        _mediator.Send(Arg.Any<CreateEmployeeCommand>())
            .Returns(EmployeeErrors.EmployeeIsNotAssignedToProfessorArea);
        // Act
        var result = (ObjectResult)await _sut.CreateEmployee(createEmployeeDTO);
        // Assert
       result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task UploadRFCDocument_ShouldReturnApiResponseWithEmployeeDto_WhenRequestIsValid()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        var employeeDTO = new EmployeeDTO();
        _mediator.Send(Arg.Any<UploadRFCDocumentCommand>()).Returns(employeeDTO);
        // Act
        var result = (ObjectResult) await _sut.UploadRFCDocument(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().BeEquivalentTo(new ApiResponse<EmployeeDTO>(employeeDTO));
    }

    [Fact]
    public async Task UploadRFCDocument_ShouldReturnBadRequestError_WhenRequestIsInvalid()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadRFCDocumentCommand>())
            .Returns(CommonErrors.InvalidFileExtension());
        // Act
        var result = (ObjectResult) await _sut.UploadRFCDocument(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task UploadRFCDocument_ShouldReturnBadRequestError_WhenDocumentIsNotUploaded()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadRFCDocumentCommand>())
            .Returns(CommonErrors.FileOrDocumentNotFound);
        // Act
        var result = (ObjectResult) await _sut.UploadRFCDocument(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task UploadRFCDocument_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadRFCDocumentCommand>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult) await _sut.UploadRFCDocument(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task UploadEmployeePicture_ShouldReturnApiResponseWithEmployeeDto_WhenRequestIsValid()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        var employeeDTO = new EmployeeDTO();
        _mediator.Send(Arg.Any<UploadEmployeePictureCommand>()).Returns(employeeDTO);
        // Act
        var result = (ObjectResult) await _sut.UploadEmployeePicture(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().BeEquivalentTo(new ApiResponse<EmployeeDTO>(employeeDTO));
    }

    [Fact]
    public async Task UploadEmployeePicture_ShouldReturnBadRequestError_WhenRequestIsInvalid()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadEmployeePictureCommand>())
            .Returns(CommonErrors.InvalidFileExtension());
        // Act
        var result = (ObjectResult) await _sut.UploadEmployeePicture(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task UploadEmployeePicture_ShouldReturnBadRequestError_WhenDocumentIsNotUploaded()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadEmployeePictureCommand>())
            .Returns(CommonErrors.FileOrDocumentNotFound);
        // Act
        var result = (ObjectResult) await _sut.UploadEmployeePicture(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
    }

    [Fact]
    public async Task UploadEmployeePicture_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
        var uplodaEmployeeFileDTO = new UploadEmployeeFileDTO();
        _mediator.Send(Arg.Any<UploadEmployeePictureCommand>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult) await _sut.UploadEmployeePicture(uplodaEmployeeFileDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task DownloadRFCDocument_ShouldReturnFile_WhenRequestIsValid()
    {
        // Arrange
        var httpContext = new DefaultHttpContext();
        _sut.ControllerContext = new ControllerContext
        {
            HttpContext = httpContext
        };
        var stream = new MemoryStream();
        var rfcDocumentName = "document.pdf";
        var donwloadEmployeeRfcDTO = new DownloadEmployeeRfcDTO
        {
            stream = stream,
            employee = new Employee { RfcDocument = rfcDocumentName}
        };
        _mediator.Send(Arg.Any<DownloadRFCDocumentCommand>()).Returns(donwloadEmployeeRfcDTO);
        // Act
        var result = (FileStreamResult) await _sut.DownloadRFCDocument(1);
        // Arrange
        var fileResult = result.Should().BeOfType<FileStreamResult>().Subject;
        result.Should().BeOfType<FileStreamResult>();
        fileResult.ContentType.Should().Be("application/octet-stream");
        result.FileStream.Should().NotBeNull();
    }

    [Fact]
    public async Task DownloadRFCDocument_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
        _mediator.Send(Arg.Any<DownloadRFCDocumentCommand>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult) await _sut.DownloadRFCDocument(1);
        // Arrange
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task UpdateEmployee_ShouldReturnApiResponseWithEmployeeDto_WhenEmployeeExists()
    {
        // Arrange
        var updateEmployeeDTO = new UpdateEmployeeDTO();
        var employeeDTO = new EmployeeDTO();
        _mediator.Send(Arg.Any<UpdateEmployeeCommand>())
            .Returns(employeeDTO);
        // Act
        var result = (ObjectResult)await _sut.UpdateEmployee(updateEmployeeDTO);
        // Assert
        result.Value.Should()
            .BeEquivalentTo(
                new ApiResponse<EmployeeDTO>(employeeDTO));
    }

    [Fact]
    public async Task UpdateEmployee_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
         var updateEmployeeDTO = new UpdateEmployeeDTO();
        _mediator.Send(Arg.Any<UpdateEmployeeCommand>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.UpdateEmployee(updateEmployeeDTO);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }

    [Fact]
    public async Task DeleteEmployee_ShouldReturnApiResponseWithMessage_WhenEmployeeExist()
    {
        // Arrange
        var mockMessage = "The resource has been deleted successfully";
        _mediator.Send(Arg.Any<DeleteEmployeeCommand>()).Returns(mockMessage);
        // Act
        var result = (ObjectResult)await _sut.DeleteEmployee(1);
        // Assert
        result.Value.Should().BeEquivalentTo(new ApiMessageResponse(mockMessage));
    }

     [Fact]
    public async Task DeleteEmployee_ShouldReturnNotFoundError_WhenEmployeeDoesNotExist()
    {
        // Arrange
        _mediator.Send(Arg.Any<DeleteEmployeeCommand>())
            .Returns(EmployeeErrors.EmployeeWithIdDoesNotExist(1));
        // Act
        var result = (ObjectResult)await _sut.DeleteEmployee(1);
        // Assert
        result.StatusCode.Should().Be(StatusCodes.Status404NotFound);
    }
}