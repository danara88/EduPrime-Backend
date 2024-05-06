using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Login model validation
/// </summary>
public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.logInUserDTO.Email)
            .NotEmpty()
            .OverridePropertyName("UserEmail");

        RuleFor(x => x.logInUserDTO.Password)
            .NotEmpty()
            .OverridePropertyName("UserPassword");
    }
}
