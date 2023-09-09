namespace EduPrime.API.Services
{
    /// <summary>
    /// Subject service interface
    /// </summary>
    public interface ISubjectService
    {
        Task<(bool, int)> ValidProfessorIds(List<int> professorIds);
    }
}
