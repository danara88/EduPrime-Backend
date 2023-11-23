using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Services
{
    /// <summary>
    /// Employee repository service
    /// </summary>
    public class EmployeeRepositoryService : IEmployeeRepositoryService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepositoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds an employee with areas to DB
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task AddEmployeeWithAreasToDB(Employee employee)
        {
            employee.Areas.ForEach(area => _context.Entry(area).State = EntityState.Unchanged);
            await _context.AddAsync(employee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
