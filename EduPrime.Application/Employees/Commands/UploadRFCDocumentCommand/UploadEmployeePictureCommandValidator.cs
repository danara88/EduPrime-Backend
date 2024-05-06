using FluentValidation;
using EduPrime.Application.Employees.Commands;

/// <summary>
/// Upload employee document model validation
/// </summary>
public class UploadRFCDocumentCommandValidator : AbstractValidator<UploadRFCDocumentCommand>
{
    public UploadRFCDocumentCommandValidator()
    {
        RuleFor(x => x.uploadEmployeeFileDTO.employeeId)
            .NotEmpty()
            .OverridePropertyName("EmployeeId");

         RuleFor(x => x.uploadEmployeeFileDTO.fileBase64)
            .NotEmpty()
            .OverridePropertyName("EmployeeFile");
    }
}
