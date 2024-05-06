using FluentValidation;

namespace EduPrime.Application.Roles.Commands;

/// <summary>
/// Update user role model validation
/// </summary>
public class UpdateUserRoleCommandValidator : AbstractValidator<UpdateUserRoleCommand>
{
    public UpdateUserRoleCommandValidator()
    {
        RuleFor(x => x.updateUserRoleDTO.RoleId)
            .NotEmpty()
            .OverridePropertyName("RoleId");

        RuleFor(x => x.updateUserRoleDTO.UserId)
            .NotEmpty()
            .OverridePropertyName("UserId");
    }
}
