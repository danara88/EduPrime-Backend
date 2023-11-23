using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Employees.Interfaces
{
    /// <summary>
    /// Employee repository interface
    /// </summary>
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<bool> ExistsAnyEmployee(int id);

        Task<List<Employee>> GetEmployeesWithProfessor();

        Task<Employee> GetEmployeeWithProfessor(int professorId);

        Task<Employee> GetEmployeeAsync(int id);
    }
}
