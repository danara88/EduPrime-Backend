using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class AreaEmployeeConfig : IEntityTypeConfiguration<AreaEmployee>
    {
        public void Configure(EntityTypeBuilder<AreaEmployee> builder)
        {
            builder.HasKey(prop => new { prop.AreaId, prop.EmployeeId });
        }
    }
}
