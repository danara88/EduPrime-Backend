using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Professor repository interface
    /// </summary>
    public interface IProfessorRepository : IBaseRepository<Professor>
    {
        Task<bool> ExistsAnyProfessor(int id);
    }
}
