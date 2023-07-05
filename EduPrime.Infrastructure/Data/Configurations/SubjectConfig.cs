using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(100);

            builder.Property(prop => prop.IsDeleted)
               .HasDefaultValue(false)
               .IsRequired();

            builder.Property(prop => prop.CreatedOn)
               .HasDefaultValue(DateTime.Now)
               .IsRequired();
        }
    }
}
