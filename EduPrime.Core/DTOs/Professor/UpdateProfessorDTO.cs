using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Professor
{
    public class UpdateProfessorDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required, Range(0, 100)]
        public int Satisfaction { get; set; }

        [Required, Range(0, 100)]
        public int YearsOnDuty { get; set; }
    }
}
