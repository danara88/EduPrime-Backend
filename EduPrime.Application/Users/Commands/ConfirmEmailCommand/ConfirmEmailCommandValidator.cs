using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Confirm email model validation
/// </summary>
public class ConfirmEmailCommandValidator : AbstractValidator<ConfirmEmailCommand>
{
    public ConfirmEmailCommandValidator()
    {
        RuleFor(x => x.confirmEmailDTO.Code)
            .NotEmpty()
            .OverridePropertyName("Code");
    }
}
