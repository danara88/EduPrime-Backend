using FluentValidation;
using EduPrime.Application.Employees.Commands;

/// <summary>
/// Upload employee picture model validation
/// </summary>
public class UploadEmployeePictureCommandValidator : AbstractValidator<UploadEmployeePictureCommand>
{
    public UploadEmployeePictureCommandValidator()
    {
        RuleFor(x => x.uploadEmployeeFileDTO.employeeId)
            .NotEmpty()
            .OverridePropertyName("EmployeeId");

         RuleFor(x => x.uploadEmployeeFileDTO.fileBase64)
            .NotEmpty()
            .OverridePropertyName("EmployeePictureFile");
    }
}
