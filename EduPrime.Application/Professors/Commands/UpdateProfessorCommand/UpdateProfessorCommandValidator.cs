using FluentValidation;
using EduPrime.Application.Professors.Commands;

/// <summary>
/// Update professor model validation
/// </summary>
public class UpdateProfessorCommandValidator : AbstractValidator<UpdateProfessorCommand>
{
    public UpdateProfessorCommandValidator()
    {
        RuleFor(x => x.updateProfessorDTO.Id)
            .NotEmpty()
            .OverridePropertyName("ProfessorId");

        RuleFor(x => x.updateProfessorDTO.Satisfaction)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("ProfessorSatisfaction");

        RuleFor(x => x.updateProfessorDTO.YearsOnDuty)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("ProfessorYearsOnDuty");
    }
}
