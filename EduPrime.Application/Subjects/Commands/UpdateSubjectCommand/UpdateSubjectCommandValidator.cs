using FluentValidation;

namespace EduPrime.Application.Subjects.Commands;

/// <summary>
/// Update subject model validation
/// </summary>
public class UpdateSubjectCommandValidator : AbstractValidator<UpdateSubjectCommand>
{
    public UpdateSubjectCommandValidator()
    {
        RuleFor(x => x.updateSubjectDTO.Id)
            .NotEmpty()
            .OverridePropertyName("SubjectId");

        RuleFor(x => x.updateSubjectDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(150)
            .OverridePropertyName("SubjectName");

        RuleFor(x => x.updateSubjectDTO.AvailableSemester)
            .IsInEnum()
            .NotEmpty()
            .OverridePropertyName("SubjectAvailableSemester");
    }
}
