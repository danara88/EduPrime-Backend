using FluentValidation;
using EduPrime.Application.Employees.Commands;

/// <summary>
/// Update employee model validation
/// </summary>
public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
{
    public UpdateEmployeeCommandValidator()
    {
        RuleFor(x => x.updateEmployeeDTO.Id)
            .NotEmpty()
            .OverridePropertyName("EmployeeId");

        RuleFor(x => x.updateEmployeeDTO.Name)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(100)
            .OverridePropertyName("EmployeeName");

        RuleFor(x => x.updateEmployeeDTO.Surname)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(200)
            .OverridePropertyName("EmployeeSurname");

        RuleFor(x => x.updateEmployeeDTO.Email)
            .NotEmpty()
            .EmailAddress()
            .OverridePropertyName("EmployeeEmail");

        RuleFor(x => x.updateEmployeeDTO.PhoneNumber)
            .NotEmpty()
            .Matches("^([0-9]{10})$")
            .OverridePropertyName("EmployeePhoneNumber");
    }
}
