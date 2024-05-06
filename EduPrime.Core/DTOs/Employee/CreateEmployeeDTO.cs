using EduPrime.Core.DTOs.Professor;

namespace EduPrime.Core.DTOs.Employee
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

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
