using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Student
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Picture { get; set; }

        public string? PhoneNumber { get; set; }

        public string EmergencyContact { get; set; }

        public SemesterTypeEnum CurrentSemester { get; set; }

        public List<StudentSubjectDTO> Assignments { get; set; }
    }
}
