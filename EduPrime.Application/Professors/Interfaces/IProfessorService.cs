namespace EduPrime.Application.Professors.Interfaces
{
    /// <summary>
    /// Professor service interface
    /// </summary>
    public interface IProfessorService
    {
        Task<(bool, int)> ValidProfessorIds(List<int> professorIds);
    }
}
