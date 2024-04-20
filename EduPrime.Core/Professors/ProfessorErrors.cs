using ErrorOr;

namespace EduPrime.Core.Professors;

/// <summary>
/// Professor domain errors
/// </summary>
public static class ProfessorErrors
{
    public static readonly Error EmployeeIsNotAssignedToProfessorArea =
        Error.Validation(
            "Professor.EmployeeIsNotAssignedToProfessorArea",
            "The employee is not assigned to a professor area.");

    public static readonly Error ProfessorAreaDoesNotExist =
        Error.Validation(
            "Professor.ProfessorAreaDoesNotExist",
            "The professor area does not exist.");

    public static Error ProfessorWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "Professor.ProfessorWithIdDoesNotExist",
            $"The professor with id {id} does not exist.");
    }
}
