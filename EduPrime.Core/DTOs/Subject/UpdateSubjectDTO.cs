using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Subject
{
    public class UpdateSubjectDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(150)]
        public string Name { get; set; }

        [Required, EnumDataType(typeof(SemesterTypeEnum))]
        public SemesterTypeEnum AvailableSemester { get; set; }
    }
}
