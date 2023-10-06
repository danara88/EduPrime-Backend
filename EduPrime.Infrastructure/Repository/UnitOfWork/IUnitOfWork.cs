using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Unit of work interface
    /// </summary>
    public interface IUnitOfWork
    {
        IAreaRepository AreaRepository { get; }

        IEmployeeRepository EmployeeRepository { get; }

        IProfessorRepository ProfessorRepository { get; }

        IStudentRepository StudentRepository { get; }

        IBaseRepository<ProfessorSubject> ProfessorSubjectRepository { get; }

        ISubjectRepository SubjectRepository { get; }

        IUserRepository UserRepository { get; }

        IBaseRepository<Role> RoleRepository { get; }

        Task SaveChangesAsync();
    }
}
