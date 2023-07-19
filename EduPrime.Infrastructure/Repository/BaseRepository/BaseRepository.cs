using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Base Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _entity;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        /// <summary>
        /// Add entity asynchronous
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(T entity)
        {
            await _entity.AddAsync(entity);
        }

        /// <summary>
        /// Delete entity (soft delete)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var entity = _entity.FirstOrDefault(e => e.Id == id);
            if (entity is not null)
            {
                entity.IsDeleted = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get all entities asynchronous
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        /// <summary>
        /// Get entity by ID asynchronous
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> GetByIdAsync(int id)
        {
            return await _entity.FirstOrDefaultAsync(e => e.Id == id);
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
           _entity.Update(entity);
        }
    }
}
