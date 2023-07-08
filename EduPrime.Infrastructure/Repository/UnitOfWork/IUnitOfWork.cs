using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Unit of work interface
    /// </summary>
    public interface IUnitOfWork
    {
        IBaseRepository<Area> AreaRepository { get; }

        IBaseRepository<Employee> EmployeeRepository { get; }

        IBaseRepository<Professor> ProfessorRepository { get; }

        IBaseRepository<Student> StudentRepository { get; }

        IBaseRepository<Subject> SubjectRepository { get; }

        IBaseRepository<User> UserRepository { get; }

        IBaseRepository<Role> RoleRepository { get; }

        Task SaveChangesAsync();
    }
}
