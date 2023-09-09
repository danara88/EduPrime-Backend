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

        IBaseRepository<Student> StudentRepository { get; }

        IBaseRepository<ProfessorSubject> ProfessorSubjectRepository { get; }

        ISubjectRepository SubjectRepository { get; }

        IBaseRepository<User> UserRepository { get; }

        IBaseRepository<Role> RoleRepository { get; }

        Task SaveChangesAsync();
    }
}
