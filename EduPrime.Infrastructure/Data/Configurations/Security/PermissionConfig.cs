using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Data.Configurations;

/// <summary>
/// Permission Entity Framework Configuration
/// </summary>
public class PermissionConfig : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> builder)
    {
        builder.Property(prop => prop.Name)
            .HasMaxLength(80);

        builder.Property(prop => prop.CreatedOn)
               .HasDefaultValue(DateTime.UtcNow)
               .IsRequired();
    }
}
