using EduPrime.Application.Areas.Commands;
using FluentValidation;

/// <summary>
/// Update area model validation
/// </summary>
public class UpdateAreaCommandValidator : AbstractValidator<UpdateAreaCommand>
{
    public UpdateAreaCommandValidator()
    {
        RuleFor(x => x.updateAreaDTO.Id)
            .NotEmpty()
            .OverridePropertyName("AreaId");

        RuleFor(x => x.updateAreaDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(150)
            .OverridePropertyName("AreaName");

        RuleFor(x => x.updateAreaDTO.Description)
            .NotEmpty()
            .MinimumLength(10)
            .MaximumLength(200)
            .OverridePropertyName("AreaDescription");
    }
}
