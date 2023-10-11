using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class CreateStudentDTO
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(3), MaxLength(200)]
        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? PictureURL { get; set; }

        [Required, RegularExpression("^([0-9]{10})$")]
        public string PhoneNumber { get; set; }

        [Required, RegularExpression("^([0-9]{10})$")]
        public string EmergencyContact { get; set; }

        [Required, EnumDataType(typeof(SemesterTypeEnum))]
        public SemesterTypeEnum CurrentSemester { get; set; }
    }
}
