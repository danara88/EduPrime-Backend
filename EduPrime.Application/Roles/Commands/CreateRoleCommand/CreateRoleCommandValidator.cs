using FluentValidation;

namespace EduPrime.Application.Roles.Commands;

/// <summary>
/// Create role model validation
/// </summary>
public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
{
    public CreateRoleCommandValidator()
    {
        RuleFor(x => x.createRoleDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("RoleName");
    }
}
