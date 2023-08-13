using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Services
{
    /// <summary>
    /// Employee service interface
    /// </summary>
    public interface IEmployeeRepositoryService
    {
        Task AddEmployeeWithAreasToDB(Employee employee);
    }
}
