using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Employee repository interface
    /// </summary>
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<bool> ExistsAnyEmployee(int id);

        Task<List<Employee>> GetEmployeesWithProfessor();
    }
}
