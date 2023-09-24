using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class UpdateStudentAssignmentDTO
    {
        [Required]
        public int StudentId { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public int FirstGrade { get; set; } = 0;

        [Required]
        public int SecondGrade { get; set; } = 0;

        [Required]
        public int FinalGrade { get; set; } = 0;

        [Required]
        public SubjectGradeStatus Status { get; set; } = SubjectGradeStatus.InProgress;
    }
}
