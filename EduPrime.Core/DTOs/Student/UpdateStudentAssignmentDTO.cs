using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Student
{
    public class UpdateStudentAssignmentDTO
    {
        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public int FirstGrade { get; set; } = 0;

        public int SecondGrade { get; set; } = 0;

        public int FinalGrade { get; set; } = 0;

        public SubjectGradeStatus Status { get; set; } = SubjectGradeStatus.InProgress;
    }
}
