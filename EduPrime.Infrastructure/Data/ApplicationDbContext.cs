using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EduPrime.Infrastructure.Data
{
    /// <summary>
    /// Application DB Context
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ProfessorSubject> ProfessorsSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentsSubjects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            DataSeedModule.Seed(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var modifiedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified && e.Entity is BaseEntity)
                .ToList();

            foreach (var entry in modifiedEntities)
            {
                var resource = (BaseEntity)entry.Entity;
                resource.UpdatedOn = DateTime.Now;
            }

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
