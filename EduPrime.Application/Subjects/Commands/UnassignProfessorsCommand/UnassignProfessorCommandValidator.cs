using FluentValidation;
using EduPrime.Core.Enums.Subject;

namespace EduPrime.Application.Subjects.Commands;

/// <summary>
/// Unassign professor model validation
/// </summary>
public class UnassignProfessorCommandValidator : AbstractValidator<UnassignProfessorsCommand>
{
    public UnassignProfessorCommandValidator()
    {
        RuleFor(x => x.unassignProfessorsDTO.SubjectId)
            .NotEmpty()
            .OverridePropertyName("SubjectId");

        RuleFor(x  => x.unassignProfessorsDTO.UnassignAction)
            .IsInEnum()
            .OverridePropertyName("UnassignProfessorAction");

        RuleFor(x => x.unassignProfessorsDTO.ProfessorIds)
            .Must((dto, professorIds) =>
                dto.unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.All ||
                dto.unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.NotAll && professorIds.Any())
            .WithMessage("Professor IDs must not be empty.")
            .OverridePropertyName("ProfessorIds");
    }
}
