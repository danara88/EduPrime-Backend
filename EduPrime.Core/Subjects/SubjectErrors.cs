using ErrorOr;

namespace EduPrime.Core.Subjects;

/// <summary>
/// Subject domain errors
/// </summary>
public static class SubjectErrors
{
    public static readonly Error SubjectRequiresAtLeastOneProfessor =
        Error.Validation(
          "Subject.SubjectRequiresAtLeastOneProfessor",
          "The subject requires at least one professor assigned."
        );

    public static readonly Error SubjectCannotBeAssignedToMoreThanTwoProfessors =
        Error.Validation(
          "Subject.SubjectCannotBeAssignedToMoreThanTwoProfessors",
          "You can only assign maximum 2 professors per subject."
        );

    public static readonly Error CannotUnassignMoreThanTwoProfessorsFromSubject =
        Error.Validation(
          "Subject.CannotUnassignMoreThanTwoProfessorsFromSubject",
          "You can only unassign maximum 2 professors per subject."
        );

    public static Error SubjectAlreadyAddedToTwoProfessors(int id)
    {
        return Error.Validation(
            "Subject.SubjectAlreadyAddedToTwoProfessors",
            $"The subject with id {id} is already assigned to 2 professors. Please unassign professors to continue.");
    }

    public static Error CannotAddMoreThanOneProfessorToSubject(int id)
    {
        return Error.Validation(
            "Subject.CannotAddMoreThanOneProfessorToSubject",
            $"You are trying to add more than 1 professor. The subject with id {id} is already assigned to 1 professor.");
    }

    public static Error SubjectWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "Subject.SubjectWithIdDoesNotExist",
            $"The subject with id {id} does not exist.");
    }

    public static Error SubjectAlreadyExists(string subjectName)
    {
        return Error.Conflict(
            "Subject.SubjectAlreadyExists",
            $"The subject with name {subjectName} already exists.");
    }
}
