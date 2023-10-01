namespace EduPrime.Core.Entities;

/// <summary>
/// Base Entity
/// This abstract class is used to implement base repository
/// </summary>
public abstract class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
