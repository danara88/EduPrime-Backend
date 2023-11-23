using EduPrime.Core.Entities;
using EduPrime.Application.Common.Interfaces;

namespace EduPrime.Application.Areas.Interfaces
{
    /// <summary>
    /// Area repository interface
    /// </summary>
    public interface IAreaRepository : IBaseRepository<Area>
    {
        Task<bool> ExistsAnyArea(string name);

        Task<bool> ExistsAnyArea(int id);

        Task<List<Area>> GetAreasWithEmployeesAsync();
    }
}
