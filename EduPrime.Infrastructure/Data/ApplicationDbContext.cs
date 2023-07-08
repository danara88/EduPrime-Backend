using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EduPrime.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            /*
             * Comment this piece of code to avoid executing seeding
             */
            // DataSeedModule.Seed(modelBuilder);
        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AreaEmployee> AreasEmployees { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ProfessorSubject> ProfessorsSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentsSubjects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
