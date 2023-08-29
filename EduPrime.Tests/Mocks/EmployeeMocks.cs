using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Entities;

namespace EduPrime.Tests.Mocks
{
    public static class EmployeeMocks
    {
        public static Employee employeeMock = new Employee
        {
            Id = 1,
            Name = "Employee name test",
            Surname = "Employee surname test",
            Email = "test@test.com",
            PhoneNumber = "8447878787",
            CreatedOn = DateTime.Now,
            Areas = null!
        };

        public static EmployeeDTO employeeDtoMock = new EmployeeDTO
        {
            Id = 1,
            Name = "Employee name test",
            Surname = "Employee surname test",
            Email = "test@test.com",
            PhoneNumber = "8447878787"
        };

        public static List<Employee> employeesMock = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Employee name test",
                Surname = "Employee surname test",
                Email = "test@test.com",
                PhoneNumber = "8447878787",
                CreatedOn = DateTime.Now,
                Areas = null!
            },
            new Employee
            {
                Id = 2,
                Name = "Employee name test",
                Surname = "Employee surname test",
                Email = "test@test.com",
                PhoneNumber = "8447878787",
                CreatedOn = DateTime.Now,
                Areas = null!
            },
        };

        public static List<EmployeeDTO> employeesDtoMock = new List<EmployeeDTO>
        {
            new EmployeeDTO
            {
                Id = 1,
                Name = "Employee name test",
                Surname = "Employee surname test",
                Email = "test@test.com",
                PhoneNumber = "8447878787"
            },
            new EmployeeDTO
            {
                Id = 2,
                Name = "Employee name test",
                Surname = "Employee surname test",
                Email = "test@test.com",
                PhoneNumber = "8447878787"
            }
        };
    }
}
