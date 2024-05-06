using FluentValidation;

namespace EduPrime.Application.Students.Commands;

/// <summary>
/// Update student assignment model validation
/// </summary>
public class UpdateStudentAssignmentCommandValidator : AbstractValidator<UpdateStudentAssignmentCommand>
{
    public UpdateStudentAssignmentCommandValidator()
    {
        RuleFor(x => x.updateStudentAssignmentDTO.StudentId)
            .NotEmpty()
            .OverridePropertyName("StudentId");

        RuleFor(x => x.updateStudentAssignmentDTO.SubjectId)
            .NotEmpty()
            .OverridePropertyName("SubjectId");

        RuleFor(x => x.updateStudentAssignmentDTO.FirstGrade)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("SubjectFirstGrade");

        RuleFor(x => x.updateStudentAssignmentDTO.SecondGrade)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("SubjectSecondGrade");

        RuleFor(x => x.updateStudentAssignmentDTO.FinalGrade)
            .InclusiveBetween(0, 100)
            .OverridePropertyName("SubjectFinalGrade");

        RuleFor(x => x.updateStudentAssignmentDTO.Status)
            .IsInEnum()
            .OverridePropertyName("SubjectStatus");
    }
}
