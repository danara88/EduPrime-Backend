using ErrorOr;
using NSubstitute;
using MediatR;
using FluentAssertions;
using EduPrime.Application.Areas.Commands;
using EduPrime.Application.Common.Behaviors;
using EduPrime.Application.Users.Interfaces;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Users;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Core.Enums;

namespace EduPrime.Application.Tests.Unit.Common.Behaviors;

public class AuthorizationBehaviorTests
{
    private readonly ICurrentUserProvider _mockCurrentUserProvider;
    private readonly RequestHandlerDelegate<ErrorOr<AreaDTO>> _mockNext;
    private readonly AuthorizationBehavior<CreateAreaCommand, ErrorOr<AreaDTO>> _sut;

    public AuthorizationBehaviorTests()
    {
        _mockNext = Substitute.For<RequestHandlerDelegate<ErrorOr<AreaDTO>>>();
        _mockCurrentUserProvider = Substitute.For<ICurrentUserProvider>();
        _sut = new AuthorizationBehavior<CreateAreaCommand, ErrorOr<AreaDTO>>(_mockCurrentUserProvider);
    }

    [Fact]
    public async Task InvokeBehavior_WhenAuthorizationSucceed_ShouldInvokeNextBehavior()
    {
        // Arrange
        var createAreaDTO = new CreateAreaDTO
        {
            Name = "Test"
        };
        var areaDTO = new AreaDTO
        {
            Name = "Test"
        };
        var createAreaCommand = new CreateAreaCommand(createAreaDTO);
        _mockNext.Invoke().Returns(areaDTO);
        _mockCurrentUserProvider.GetCurrentUser().Returns(new CurrentUser(

            Id: 1,
            Permissions: new List<string>
            {
                PermissionsConsts.CreateAreasPermission
            },
            Roles: new List<string>
            {
                RoleTypeEnum.Primary.ToString(),
            }
        ));

        // Act
        var result = await _sut.Handle(createAreaCommand, _mockNext, default);

        // Assert
        result.IsError.Should().BeFalse();
    }

     [Fact]
    public async Task InvokeBehavior_WhenAuthorizationFail_ShouldReturnErrors()
    {
        // Arrange
        var createAreaDTO = new CreateAreaDTO
        {
            Name = "Test"
        };
        var createAreaCommand = new CreateAreaCommand(createAreaDTO);
        _mockCurrentUserProvider.GetCurrentUser().Returns(new CurrentUser(
            Id: 1,
            Permissions: new List<string>
            {
                PermissionsConsts.CreateEmployeesPermission
            },
            Roles: new List<string>
            {
                RoleTypeEnum.Primary.ToString(),
            }
        ));

        // Act
        var result = await _sut.Handle(createAreaCommand, _mockNext, default);

        // Assert
        result.IsError.Should().BeTrue();
        result.FirstError.Type.Should().Be(ErrorType.Forbidden);
        result.FirstError.Description.Should().Be("User is forbidden from taking this action.");
    }
}
