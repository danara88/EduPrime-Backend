using ErrorOr;

namespace EduPrime.Core.Employees;

/// <summary>
/// Employee domain errors
/// </summary>
public static class EmployeeErrors
{
    public static readonly  Error EmployeeIsNotAssignedToProfessorArea =
        Error.Validation(
            "Employee.EmployeeIsNotAssignedToProfessorArea",
            "You cannot assign a professor resource since not any area where assigned to the employee.");


    public static readonly Error EmployeeIsAssignedToProfessorResourceButNotAssignedToProfessorArea =
        Error.Validation(
            "Employee.EmployeeIsAssignedToProfessorResourceButNotAssignedToProfessorArea",
            "The employee needs to be in the professor area to be attached to a professor resource.");

    public static readonly Error EmployeeDoesNotHaveAnyAttachedRfcDocument =
        Error.Validation(
            "Employee.EmployeeDoesNotHaveAnyAttachedRfcDocument",
            "The employee doesn't have any attached RFC document.");

    public static Error EmployeeWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "Employee.EmployeeWithIdDoesNotExist",
            $"The employee with id {id} does not exist.");
    }
}
