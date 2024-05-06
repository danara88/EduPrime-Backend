using FluentValidation;

namespace EduPrime.Application.Users.Commands;

/// <summary>
/// Recovery password model validation
/// </summary>
public class RecoveryPasswordCommandValidator : AbstractValidator<RecoveryPasswordCommand>
{
    public RecoveryPasswordCommandValidator()
    {
        RuleFor(x => x.recoveryPasswordDTO.Email)
            .NotEmpty()
            .EmailAddress()
            .OverridePropertyName("UserEmail");
    }
}
