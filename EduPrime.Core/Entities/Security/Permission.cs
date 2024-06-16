namespace EduPrime.Core.Entities;

/// <summary>
/// Permission Entity
/// </summary>
public class Permission : BaseEntity
{
    public string Name { get; set; }

    public List<PermissionRole> PermissionsRoles { get; set; }
}
