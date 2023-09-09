using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Subject repository interface
    /// </summary>
    public interface ISubjectRepository : IBaseRepository<Subject>
    {
        Task<List<Subject>> GetSubjectsWithProfessorsAsync();

        Task<Subject> GetSubjectWithProfessorsAsync(int id);

        Task<bool> ExistsAnySubject(string name);

        Task<bool> ExistsAnySubject(int id);
    }
}
