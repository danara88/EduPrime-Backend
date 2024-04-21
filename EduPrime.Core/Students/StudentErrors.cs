using ErrorOr;

namespace EduPrime.Core.Students;

/// <summary>
/// Student domain errors
/// </summary>
public static class StudentErrors
{
    public static readonly Error StudentRequiresAtLeastOneSubject =
        Error.Validation(
            "Student.StudentRequiresAtLeastOneSubject",
            "The student requires to be assigned at least to one subject."
        );

    public static Error StudentWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "Student.StudentWithIdDoesNotExist",
            $"The student with id {id} does not exist.");
    }

    public static Error StudentIsNotAssignedToSubject(int subjectId)
    {
        return Error.NotFound(
            "Student.StudentIsNotAssignedToSubject",
            $"The student is not assigned to the subject with id {subjectId}");
    }
}
