using EduPrime.Application.Students.Commands;
using FluentValidation;

namespace EduPrime.Core.Students.Commands;

/// <summary>
/// Upload student picture model validation
/// </summary>
public class UploadStudentPictureCommandValidator : AbstractValidator<UploadStudentPictureCommand>
{
    public UploadStudentPictureCommandValidator()
    {
        RuleFor(x => x.uploadStudentFileDTO.studentId)
            .NotEmpty()
            .OverridePropertyName("StudentId");

        RuleFor(x => x.uploadStudentFileDTO.fileBase64)
            .NotEmpty()
            .OverridePropertyName("StudentPictureFile");
    }
}
