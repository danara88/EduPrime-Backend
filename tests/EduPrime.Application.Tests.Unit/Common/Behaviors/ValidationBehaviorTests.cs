using ErrorOr;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using NSubstitute;
using EduPrime.Application.Areas.Commands;
using EduPrime.Application.Common.Behaviors;
using EduPrime.Core.DTOs.Area;

namespace EduPrime.Application.Tests.Unit.Common.Behaviors;

public class ValidationBehaviorTests
{
    private readonly RequestHandlerDelegate<ErrorOr<AreaDTO>> _mockNext;
    private readonly ValidationBehavior<CreateAreaCommand, ErrorOr<AreaDTO>> _sut;
    private readonly IValidator<CreateAreaCommand> _mockValidator;

    public ValidationBehaviorTests()
    {
        _mockNext = Substitute.For<RequestHandlerDelegate<ErrorOr<AreaDTO>>>();
        _mockValidator = Substitute.For<IValidator<CreateAreaCommand>>();
        _sut = new ValidationBehavior<CreateAreaCommand, ErrorOr<AreaDTO>>(_mockValidator);
    }

    [Fact]
    public async Task InvokeBehavior_WhenValidatorResultIsValid_ShouldInvokeNextBehavior()
    {
        // Arrange
        var createAreaDTO = new CreateAreaDTO
        {
            Name = "Test",
            Description = "Test"
        };
        var areaDTO = new AreaDTO
        {
            Id = 1,
            Name = "Test",
            Description = "Test"
        };
        var createAreaCommand = new CreateAreaCommand(createAreaDTO);

        _mockValidator
            .ValidateAsync(createAreaCommand, Arg.Any<CancellationToken>())
            .Returns(new ValidationResult());

        _mockNext.Invoke().Returns(areaDTO);

        // Act
        var result = await _sut.Handle(createAreaCommand, _mockNext, default);

        // Assert
        result.IsError.Should().BeFalse();
        result.Value.Should().BeEquivalentTo(areaDTO);
    }

    [Fact]
    public async Task InvokeBehavior_WhenValidatorResultIsNotValid_ShouldReturnErrors()
    {
        // Arrange
        var validationErrors = new List<ValidationFailure>
        {
            new (propertyName: "PropertyNameTest", errorMessage: "TestErrorMessage")
            {
                ErrorCode = "ErrorCodeTest"
            }
        };
        var createAreaDTO = new CreateAreaDTO
        {
            Name = "",
            Description = ""
        };
        var createAreaCommand = new CreateAreaCommand(createAreaDTO);

        _mockValidator
            .ValidateAsync(createAreaCommand, Arg.Any<CancellationToken>())
            .Returns(new ValidationResult(validationErrors));

        // Act
        var result = await _sut.Handle(createAreaCommand, _mockNext, default);

        // Assert
        result.IsError.Should().BeTrue();
        result.FirstError.Code.Should().Be("ErrorCodeTest");
        result.FirstError.Description.Should().Be("TestErrorMessage");
    }
}
