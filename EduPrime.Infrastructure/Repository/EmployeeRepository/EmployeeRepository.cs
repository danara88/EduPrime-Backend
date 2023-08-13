using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Verifies if an employee exists by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> ExistsAnyEmployee(int id)
        {
            return await _entity.AnyAsync(e => e.Id == id);
        }

        /// <summary>
        /// Gets all employees that are professors
        /// </summary>
        /// <returns></returns>
        public async Task<List<Employee>> GetEmployeesWithProfessor()
        {
            return await _entity
                .Include(e => e.Professor)
                .Where(e => e.Professor.Id > 0)
                .ToListAsync();
        }
    }
}
