using EduPrime.Application.Areas.Commands;
using FluentValidation;

/// <summary>
/// Create area model validation
/// </summary>
public class CreateAreaCommandValidator : AbstractValidator<CreateAreaCommand>
{
    public CreateAreaCommandValidator()
    {
        RuleFor(x => x.createAreaDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(150)
            .OverridePropertyName("AreaName");

        RuleFor(x => x.createAreaDTO.Description)
            .NotEmpty()
            .MinimumLength(10)
            .MaximumLength(200)
            .OverridePropertyName("AreaDescription");
    }
}
