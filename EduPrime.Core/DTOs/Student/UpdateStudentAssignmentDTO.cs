using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class UpdateStudentAssignmentDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int StudentId { get; set; }

        [Required, Range(1, int.MaxValue)]
        public int SubjectId { get; set; }

        [Required, Range(0, 100)]
        public int FirstGrade { get; set; } = 0;

        [Required, Range(0, 100)]
        public int SecondGrade { get; set; } = 0;

        [Required, Range(0, 100)]
        public int FinalGrade { get; set; } = 0;

        [Required, EnumDataType(typeof(SubjectGradeStatus))]
        public SubjectGradeStatus Status { get; set; } = SubjectGradeStatus.InProgress;
    }
}
