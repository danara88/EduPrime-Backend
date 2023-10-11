using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        /// <summary>
        /// User Entity Framework Configuration
        /// </summary>
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(prop => prop.Email)
                .IsUnicode(false)
                .HasMaxLength(100);

            builder.Property(prop => prop.Password)
              .IsUnicode(false)
              .HasMaxLength(100);

            builder.Property(prop => prop.LastLogin)
                .IsRequired(false);

            builder.HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);

            builder.Property(prop => prop.CreatedOn)
               .HasDefaultValue(DateTime.UtcNow)
               .IsRequired();
        }
    }
}
