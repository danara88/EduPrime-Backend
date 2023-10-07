using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Unit of work implementation
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly IAreaRepository _areaRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IProfessorRepository _professorRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly IBaseRepository<ProfessorSubject> _professorSubjectRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IAreaRepository AreaRepository => _areaRepository ?? new AreaRepository(_context);

        public IEmployeeRepository EmployeeRepository => _employeeRepository ?? new EmployeeRepository(_context);

        public IProfessorRepository ProfessorRepository => _professorRepository ?? new ProfessorRepository(_context);

        public IBaseRepository<ProfessorSubject> ProfessorSubjectRepository => _professorSubjectRepository ?? new BaseRepository<ProfessorSubject>(_context);

        public IStudentRepository StudentRepository => _studentRepository ?? new StudentRepository(_context);

        public ISubjectRepository SubjectRepository => _subjectRepository ?? new SubjectRepository(_context);

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);

        public IRoleRepository RoleRepository => _roleRepository ?? new RoleRepository(_context);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
