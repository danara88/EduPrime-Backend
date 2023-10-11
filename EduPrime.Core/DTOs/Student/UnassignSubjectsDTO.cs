using EduPrime.Core.Enums;
using EduPrime.Core.Enums.Student;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class UnassignSubjectsDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int StudentId { get; set; }

        [Required, EnumDataType(typeof(UnassignSubjectsActionEnum))]
        public UnassignSubjectsActionEnum UnassignAction { get; set; } = UnassignSubjectsActionEnum.NotAll;

        [Required]
        public List<int> SubjectIds { get; set; }
    }
}
