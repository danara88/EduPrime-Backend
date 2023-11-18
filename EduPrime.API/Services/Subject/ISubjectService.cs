namespace EduPrime.Api.Services
{
    /// <summary>
    /// Subject service interface
    /// </summary>
    public interface ISubjectService
    {
        Task<(bool, int)> ValidProfessorIds(List<int> professorIds);
    }
}
