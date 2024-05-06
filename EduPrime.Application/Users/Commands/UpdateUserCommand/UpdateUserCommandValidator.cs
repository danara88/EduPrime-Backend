using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Update user model validation
/// </summary>
public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserCommandValidator()
    {
        RuleFor(x => x.updateUserDTO.Id)
            .NotEmpty()
            .OverridePropertyName("UserId");

        RuleFor(x => x.updateUserDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("UserName");

        RuleFor(x => x.updateUserDTO.Surname)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(200)
            .OverridePropertyName("UserSurname");

        RuleFor(x => x.updateUserDTO.Email)
            .NotEmpty()
            .EmailAddress()
            .OverridePropertyName("UserEmail");
    }
}
