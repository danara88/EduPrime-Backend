﻿using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Role Entity Framework Configuration
    /// </summary>
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(50);

            builder.Property(prop => prop.CreatedOn)
               .HasDefaultValue(DateTime.UtcNow)
               .IsRequired();
        }
    }
}
