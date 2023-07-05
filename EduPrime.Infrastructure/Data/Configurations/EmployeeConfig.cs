using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
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

            builder.Property(prop => prop.Picture)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(prop => prop.RfcDocument)
               .HasMaxLength(500)
               .IsUnicode(false);

            builder.Property(prop => prop.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder.Property(prop => prop.CreatedOn)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();
        }
    }
}
