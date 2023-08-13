namespace EduPrime.Core.DTOs.Professor
{
    public class EmployeeAsProfessorDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public ProfessorDTO Professor { get; set; }
    }
}
