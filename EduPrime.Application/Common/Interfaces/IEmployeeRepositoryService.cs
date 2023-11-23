using EduPrime.Core.Entities;

namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// Employee service interface
    /// </summary>
    public interface IEmployeeRepositoryService
    {
        Task AddEmployeeWithAreasToDB(Employee employee);
    }
}
