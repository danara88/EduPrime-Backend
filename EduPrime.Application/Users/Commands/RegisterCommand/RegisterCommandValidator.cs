using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Register user model validation
/// </summary>
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.registerUserDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("UserName");

        RuleFor(x => x.registerUserDTO.Surname)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(200)
            .OverridePropertyName("UserSurname");

        RuleFor(x => x.registerUserDTO.Email)
            .NotEmpty()
            .EmailAddress()
            .OverridePropertyName("UserEmail");

        RuleFor(x => x.registerUserDTO.Password)
            .NotEmpty()
            .OverridePropertyName("UserPassword");
    }
}
