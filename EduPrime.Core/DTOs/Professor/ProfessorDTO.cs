using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Core.DTOs.Professor
{
    public class ProfessorDTO
    {
        public int Id { get; set; }

        public int Satisfaction { get; set; }

        public int YearsOnDuty { get; set; }

        public EmployeeDTO Employee { get; set; }
    }
}
