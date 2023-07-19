namespace EduPrime.Core.DTOs.Area
{
    public class AreaWithEmployeesDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<EmployeeForAreaDTO> Employees { get; set; }
    }
}
