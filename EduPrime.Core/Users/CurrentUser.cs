namespace EduPrime.Core.Users;

/// <summary>
/// Current user details
/// </summary>
public record CurrentUser(
    int Id,
    IReadOnlyList<string> Permissions,
    IReadOnlyList<string> Roles
);
