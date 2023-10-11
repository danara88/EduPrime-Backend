using EduPrime.Core.Enums.Subject;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Subject
{
    public class UnassignProfessorsDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int SubjectId { get; set; }

        [Required, EnumDataType(typeof(UnassignProfessorsActionEnum))]
        public UnassignProfessorsActionEnum UnassignAction { get; set; } = UnassignProfessorsActionEnum.NotAll;

        [Required]
        public List<int> ProfessorIds { get; set; }
    }
}
