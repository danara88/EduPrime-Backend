using FluentValidation;
using EduPrime.Application.Employees.Commands;

/// <summary>
/// Create employee model validation
/// </summary>
public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
{
    public CreateEmployeeCommandValidator()
    {
        RuleFor(x => x.createEmployeeDTO.Name)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(100)
            .OverridePropertyName("EmployeeName");

        RuleFor(x => x.createEmployeeDTO.Surname)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(200)
            .OverridePropertyName("EmployeeSurname");

        RuleFor(x => x.createEmployeeDTO.Email)
            .NotEmpty()
            .EmailAddress()
            .OverridePropertyName("EmployeeEmail");

        RuleFor(x => x.createEmployeeDTO.PhoneNumber)
            .NotEmpty()
            .Matches("^([0-9]{10})$")
            .OverridePropertyName("EmployeePhoneNumber");
    }
}
