using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class AssignSubjectsDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int StudentId { get; set; }

        [Required]
        public List<int> SubjectIds { get; set; }
    }
}
