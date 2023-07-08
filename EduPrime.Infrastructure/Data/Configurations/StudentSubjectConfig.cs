using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduPrime.Infrastructure.Data.Configurations
{
    public class StudentSubjectConfig : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(prop => new { prop.StudentId, prop.SubjectId });

            builder.Property(prop => prop.FirstGrade)
                .HasDefaultValue(0);

            builder.Property(prop => prop.SecondGrade)
               .HasDefaultValue(0);

            builder.Property(prop => prop.FinalGrade)
               .HasDefaultValue(0);

            builder.Property(prop => prop.Status)
              .HasDefaultValue(SubjectGradeStatus.InProgress);

            builder.Property(prop => prop.CreatedOn)
             .IsRequired();
        }
    }
}
