using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(50);

            builder.Property(prop => prop.Surname)
                .HasMaxLength(100);

            builder.Property(prop => prop.BirthDate)
                .HasColumnType("date")
                .IsRequired(false);

            builder.Property(prop => prop.Picture)
                .HasMaxLength(500)
                .IsUnicode(false)
                .IsRequired(false);

            builder.Property(prop => prop.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);

            builder.Property(prop => prop.EmergencyContact)
               .HasMaxLength(10)
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
