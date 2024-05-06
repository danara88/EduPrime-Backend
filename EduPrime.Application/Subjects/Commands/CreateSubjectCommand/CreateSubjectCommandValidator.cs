using FluentValidation;

namespace EduPrime.Application.Subjects.Commands;

/// <summary>
/// Create subject model validation
/// </summary>
public class CreateSubjectCommandValidator : AbstractValidator<CreateSubjectCommand>
{
    public CreateSubjectCommandValidator()
    {
        RuleFor(x => x.createSubjectDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("SubjectName");

        RuleFor(x => x.createSubjectDTO.AvailableSemester)
            .IsInEnum()
            .NotEmpty()
            .OverridePropertyName("SubjectAvailableSemester");
    }
}
