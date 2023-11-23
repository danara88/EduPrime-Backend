using EduPrime.Application.Areas.Interfaces;
using EduPrime.Application.Employees.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Application.Roles.Interfaces;
using EduPrime.Application.Students.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Application.Users.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Common.Interfaces
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

        IRoleRepository RoleRepository { get; }

        Task SaveChangesAsync();
    }
}
