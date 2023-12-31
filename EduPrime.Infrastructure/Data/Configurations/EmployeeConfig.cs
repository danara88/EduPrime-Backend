﻿using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Employee Entity Framework Configuration
    /// </summary>
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.Surname)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.BirthDate)
                .HasColumnType("date");

            builder.Property(prop => prop.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(prop => prop.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(prop => prop.PictureURL)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(prop => prop.RfcDocument)
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(prop => prop.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow)
                .IsRequired();

            builder.HasOne(employee => employee.Professor)
                .WithOne(professor => professor.Employee)
                .HasForeignKey<Professor>(professor => professor.EmployeeId);
        }
    }
}
