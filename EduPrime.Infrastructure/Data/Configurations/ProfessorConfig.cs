using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class ProfessorConfig : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.Property(prop => prop.Satisfaction)
                .HasMaxLength(100)
                .HasDefaultValue(0);

            builder.Property(prop => prop.IsDeleted)
              .HasDefaultValue(false)
              .IsRequired();

            builder.Property(prop => prop.YearsOnDuty)
                .HasDefaultValue(0);
        }
    }
}
