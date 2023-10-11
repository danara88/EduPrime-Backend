using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Subject
{
    public class CreateSubjectDTO
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, EnumDataType(typeof(SemesterTypeEnum))]
        public SemesterTypeEnum AvailableSemester { get; set; }

        public List<int> ProfessorIds { get; set; }
    }
}
