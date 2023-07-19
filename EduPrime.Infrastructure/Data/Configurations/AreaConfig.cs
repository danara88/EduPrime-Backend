using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class AreaConfig : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.Property(prop => prop.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(prop => prop.Name)
                .HasFilter("isDeleted = 'false'")
                .IsUnique();

            builder.Property(prop => prop.Description)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(prop => prop.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasQueryFilter(prop => !prop.IsDeleted);

            builder.Property(prop => prop.CreatedOn)
                .HasDefaultValue(DateTime.Now)
               .IsRequired();
        }
    }
}
