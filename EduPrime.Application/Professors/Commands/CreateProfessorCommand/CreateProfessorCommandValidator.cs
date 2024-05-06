using FluentValidation;
using EduPrime.Application.Professors.Commands;

/// <summary>
/// Create professor model validation
/// </summary>
public class CreateProfessorCommandValidator : AbstractValidator<CreateProfessorCommand>
{
    public CreateProfessorCommandValidator()
    {
        RuleFor(x => x.createProfessorDTO.EmployeeId)
            .NotEmpty()
            .OverridePropertyName("EmployeeId");

        RuleFor(x => x.createProfessorDTO.Satisfaction)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("ProfessorSatisfaction");

        RuleFor(x => x.createProfessorDTO.YearsOnDuty)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("ProfessorYearsOnDuty");
    }
}
