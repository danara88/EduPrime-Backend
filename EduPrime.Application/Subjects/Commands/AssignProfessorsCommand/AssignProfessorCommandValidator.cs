using FluentValidation;

namespace EduPrime.Application.Subjects.Commands;

/// <summary>
/// Assign professor model validation
/// </summary>
public class AssignProfessorCommandValidator : AbstractValidator<AssignProfessorsCommand>
{
    public AssignProfessorCommandValidator()
    {
        RuleFor(x => x.assignProfessorsDTO.SubjectId)
            .NotEmpty()
            .OverridePropertyName("SubjectId");

        RuleFor(x => x.assignProfessorsDTO.ProfessorIds)
            .NotEmpty()
            .OverridePropertyName("ProfessorsIds");
    }
}
