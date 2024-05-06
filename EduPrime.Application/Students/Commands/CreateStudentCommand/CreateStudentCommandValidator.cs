using FluentValidation;

namespace EduPrime.Application.Students.Commands;

/// <summary>
/// Create student model validation
/// </summary>
public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
{
    public CreateStudentCommandValidator()
    {
        RuleFor(x => x.createStudentDTO.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(100)
            .OverridePropertyName("StudentName");

        RuleFor(x => x.createStudentDTO.Surname)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(200)
            .OverridePropertyName("StudentSurname");

        RuleFor(x => x.createStudentDTO.PhoneNumber)
          .NotEmpty()
          .Matches("^([0-9]{10})$")
          .OverridePropertyName("StudentPhoneNumber");

        RuleFor(x => x.createStudentDTO.EmergencyContact)
          .NotEmpty()
          .Matches("^([0-9]{10})$")
          .OverridePropertyName("EmergencyContactPhoneNumber");

        RuleFor(x => x.createStudentDTO.CurrentSemester)
          .NotEmpty()
          .IsInEnum()
          .OverridePropertyName("StudentCurrentSemester");
    }
}
