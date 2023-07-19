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
        private readonly IBaseRepository<Employee> _employeeRepository;
        private readonly IBaseRepository<Professor> _professorRepository;
        private readonly IBaseRepository<Student> _studentRepository;
        private readonly IBaseRepository<Subject> _subjectRepository;
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Role> _roleRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IAreaRepository AreaRepository => _areaRepository ?? new AreaRepository(_context);

        public IBaseRepository<Employee> EmployeeRepository => _employeeRepository ?? new BaseRepository<Employee>(_context);

        public IBaseRepository<Professor> ProfessorRepository => _professorRepository ?? new BaseRepository<Professor>(_context);

        public IBaseRepository<Student> StudentRepository => _studentRepository ?? new BaseRepository<Student>(_context);

        public IBaseRepository<Subject> SubjectRepository => _subjectRepository ?? new BaseRepository<Subject>(_context);

        public IBaseRepository<User> UserRepository => _userRepository ?? new BaseRepository<User>(_context);

        public IBaseRepository<Role> RoleRepository => _roleRepository ?? new BaseRepository<Role>(_context);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
