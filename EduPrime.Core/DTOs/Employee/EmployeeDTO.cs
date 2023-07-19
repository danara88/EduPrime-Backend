namespace EduPrime.Core.DTOs.Employee
{
    public class EmployeeDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string? Picture { get; set; }

        public string? RfcDocument { get; set; }
    }
}
