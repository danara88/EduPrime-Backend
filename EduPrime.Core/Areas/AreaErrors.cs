using ErrorOr;

namespace EduPrime.Core.Areas;

/// <summary>
/// Area domain errors
/// </summary>
public static class AreaErrors
{
    public static Error AreaWithNameAlreadyExists(string name) {
        return Error.Conflict(
            "Area.AreaWithNameAlreadyExists",
            $"The area with name {name} already exists.");
    }

    public static Error AreaWithIdDoesNotExist(int id) {
        return Error.NotFound(
            "Area.AreaWithIdDoesNotExist",
            $"The area with id {id} does not exist.");
    }
}
