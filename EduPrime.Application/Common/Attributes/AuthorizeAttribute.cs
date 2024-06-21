namespace EduPrime.Application.Common.Attributes;

/// <summary>
/// Authorize attribute to implement role-based authorization
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class AuthorizeAttribute : Attribute
{
    public string? Permissions { get; set; }

    public string? Roles { get; set; }
}
