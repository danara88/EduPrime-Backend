using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Area
{
    public class CreateAreaDTO
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
    }
}
