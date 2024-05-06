using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Change password model validation
/// </summary>
public class ChangePasswordCommandValidator : AbstractValidator<ChangePasswordCommand>
{
    public ChangePasswordCommandValidator()
    {
        RuleFor(x => x.changePasswordDTO.Email)
            .NotEmpty()
            .OverridePropertyName("UserEmail");

        RuleFor(x => x.changePasswordDTO.Password)
            .NotEmpty()
            .OverridePropertyName("UserNewPassword");
    }
}
