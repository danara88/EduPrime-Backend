using FluentValidation;
using EduPrime.Application.Students.Commands;
using EduPrime.Core.Enums.Student;

namespace EduPrime.Application.Subjects.Commands;

/// <summary>
/// Unassign subjects model validation
/// </summary>
public class UnassignSubjectsCommandValidator : AbstractValidator<UnassignSubjectsCommand>
{
    public UnassignSubjectsCommandValidator()
    {
        RuleFor(x => x.unassignSubjectsDTO.StudentId)
            .NotEmpty()
            .OverridePropertyName("StudentId");

        RuleFor(x  => x.unassignSubjectsDTO.UnassignAction)
            .IsInEnum()
            .OverridePropertyName("UnassignSubjectAction");

        RuleFor(x => x.unassignSubjectsDTO.SubjectIds)
            .Must((dto, subjectIds) =>
                dto.unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.All ||
                dto.unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.NotAll && subjectIds.Any())
            .WithMessage("Subject IDs must not be empty.")
            .OverridePropertyName("SubjectIds");
    }
}
