using EmployeeEntity = EduPrime.Core.Entities.Employee;

namespace EduPrime.Core.DTOs.Employee
{
    public class DownloadEmployeeRfcDTO
    {
        public Stream stream { get; set; }

        public EmployeeEntity employee { get; set; }
    }
}
