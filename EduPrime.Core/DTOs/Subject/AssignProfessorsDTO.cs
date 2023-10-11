using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Subject
{
    public class AssignProfessorsDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int SubjectId { get; set; }

        [Required]
        public List<int> ProfessorIds { get; set; }
    }
}
