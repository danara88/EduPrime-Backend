using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Data.Configurations;

/// <summary>
/// PermissionRole Entity Framework Configuration
/// </summary>
public class PermissionRoleConfig : IEntityTypeConfiguration<PermissionRole>
{
    public void Configure(EntityTypeBuilder<PermissionRole> builder)
    {
        builder.HasKey(prop => new { prop.RoleId, prop.PermissionId });

        // Ignored fiels
        builder.Ignore(pr => pr.Id);
        builder.Ignore(pr => pr.CreatedOn);
        builder.Ignore(pr => pr.UpdatedOn);
    }
}
