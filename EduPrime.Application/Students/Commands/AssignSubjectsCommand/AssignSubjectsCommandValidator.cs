using FluentValidation;

namespace EduPrime.Application.Students.Commands;

/// <summary>
/// Assign subjects to student model validation
/// </summary>
public class AssignSubjectsCommandValidator : AbstractValidator<AssignSubjectsCommand>
{
    public AssignSubjectsCommandValidator()
    {
        RuleFor(x => x.assignSubjectsDTO.StudentId)
            .NotEmpty()
            .OverridePropertyName("StudentId");

        RuleFor(x => x.assignSubjectsDTO.SubjectIds)
            .NotEmpty()
            .OverridePropertyName("SubjectsIds");
    }
}
