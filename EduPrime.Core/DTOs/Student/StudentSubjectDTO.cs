using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Student
{
    public class StudentSubjectDTO
    {
        public int FirstGrade { get; set; }

        public int SecondGrade { get; set; }

        public int FinalGrade { get; set; }

        public SubjectGradeStatus Status { get; set; }

        public SubjectDTO Subject { get; set; }
    }
}
