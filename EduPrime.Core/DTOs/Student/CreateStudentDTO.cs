using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class CreateStudentDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string PictureURL { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public string EmergencyContact { get; set; }

        public SemesterTypeEnum CurrentSemester { get; set; }
    }
}
