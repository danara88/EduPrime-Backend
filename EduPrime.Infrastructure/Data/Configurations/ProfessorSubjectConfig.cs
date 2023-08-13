using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    /// <summary>
    /// ProfessorSubject Entity Framework Configuration
    /// </summary>
    public class ProfessorSubjectConfig : IEntityTypeConfiguration<ProfessorSubject>
    {
        public void Configure(EntityTypeBuilder<ProfessorSubject> builder)
        {
            builder.HasKey(prop => new { prop.ProfessorId, prop.SubjectId });
        }
    }
}
