namespace EduPrime.Core.Entities;

/// <summary>
/// PermissionRole Entity
/// </summary>
public class PermissionRole : BaseEntity
{
    public int RoleId { get; set; }

    public int PermissionId { get; set; }

    public Role Role { get; set; }

    public Permission Permission { get; set; }
}
