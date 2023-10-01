using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Professor Entity Framework Configuration
    /// </summary>
    public class ProfessorConfig : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.Property(prop => prop.Satisfaction)
                .HasMaxLength(100)
                .HasDefaultValue(0);

            builder.Property(prop => prop.YearsOnDuty)
                .HasDefaultValue(0);

            builder.Property(prop => prop.CreatedOn)
                .HasDefaultValue(DateTime.Now)
                .IsRequired();

            builder.HasOne(professor => professor.Employee)
                .WithOne(employee => employee.Professor);
        }
    }
}
