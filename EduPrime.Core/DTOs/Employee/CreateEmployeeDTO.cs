using EduPrime.Core.DTOs.Professor;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Employee
{
    public class CreateEmployeeDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string? PictureURL { get; set; }

        public string? RfcDocument { get; set; }

        public CreateProfessorDTO? Professor { get; set; }

        /// <summary>
        /// List of areas IDs
        /// </summary>
        public List<int>? Areas { get; set; }
    }
}
