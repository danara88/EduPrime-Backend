using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Subject
{
    public class CreateSubjectDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public SemesterTypeEnum AvailableSemester { get; set; }

        public List<int> ProfessorIds { get; set; }
    }
}
