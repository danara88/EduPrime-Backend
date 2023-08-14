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

        /// <summary>
        /// Gets an employee with professor data by professor id
        /// </summary>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeWithProfessor(int professorId)
        {
            return await _entity
                .Include(e => e.Professor)
                .FirstOrDefaultAsync(e => e.Professor.Id == professorId);
        }

        /// <summary>
        /// Gets an employee
        /// </summary>
        /// <returns></returns>
        public async Task<Employee> GetEmployeeAsync(int id)
        {
            return await _entity.Include(e => e.Areas).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
