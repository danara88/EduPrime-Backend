using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class ProfessorSubjectConfig : IEntityTypeConfiguration<ProfessorSubject>
    {
        public void Configure(EntityTypeBuilder<ProfessorSubject> builder)
        {
            builder.HasKey(prop => new { prop.ProfessorId, prop.SubjectId });
        }
    }
}
