using ErrorOr;

namespace EduPrime.Core.Roles;

/// <summary>
/// Role domain errors
/// </summary>
public static class RoleErrors
{
    public static Error RoleWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "Role.RoleWithIdDoesNotExist",
            $"The role with id {id} does not exist.");
    }

    public static Error RoleWithNameAlreadyExists(string roleName)
    {
        return Error.Conflict(
            "Role.RoleWithNameAlreadyExists",
            $"The role with name {roleName} already exists.");
    }
}
