using FluentValidation;

namespace EduPrime.Application.Students.Commands;

/// <summary>
/// Update student model validation
/// </summary>
public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
{
    public UpdateStudentCommandValidator()
    {
        RuleFor(x => x.updateStudentDTO.Id)
            .NotEmpty()
            .OverridePropertyName("StudentId");

        RuleFor(x => x.updateStudentDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("StudentName");

        RuleFor(x => x.updateStudentDTO.Surname)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(200)
            .OverridePropertyName("StudentSurname");

        RuleFor(x => x.updateStudentDTO.PhoneNumber)
          .NotEmpty()
          .Matches("^([0-9]{10})$")
          .OverridePropertyName("StudentPhoneNumber");

        RuleFor(x => x.updateStudentDTO.EmergencyContact)
          .NotEmpty()
          .Matches("^([0-9]{10})$")
          .OverridePropertyName("EmergencyContactPhoneNumber");

        RuleFor(x => x.updateStudentDTO.CurrentSemester)
          .NotEmpty()
          .IsInEnum()
          .OverridePropertyName("StudentCurrentSemester");
    }
}
