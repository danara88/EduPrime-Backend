using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Area
{
    public class CreateAreaDTO
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
