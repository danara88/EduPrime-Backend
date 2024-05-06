using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Student
{
    public class CreateStudentDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? PictureURL { get; set; }

        public string PhoneNumber { get; set; }

        public string EmergencyContact { get; set; }

        public SemesterTypeEnum CurrentSemester { get; set; }
    }
}
