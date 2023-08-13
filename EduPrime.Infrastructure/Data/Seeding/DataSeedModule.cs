using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Data.Seeding
{
    /// <summary>
    /// In charge of generating fake data
    /// </summary>
    public static class DataSeedModule
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            /**
             * Areas
             */
            var professorArea = new Area { Id = 1, Name = "Professor", Description = "Only those who teach a subject", CreatedOn = DateTime.Now };
            var administrativeArea = new Area { Id = 2, Name = "Office administrative", Description = "Office administrative area", CreatedOn = DateTime.Now };
            var cleaningArea = new Area { Id = 3, Name = "Clean service", Description = "School clean service", CreatedOn = DateTime.Now };
            var securityGuardArea = new Area { Id = 4, Name = "Security guard", Description = "School security guard", CreatedOn = DateTime.Now };

            modelBuilder.Entity<Area>().HasData(professorArea, administrativeArea, cleaningArea, securityGuardArea);

            /**
             * Employees
             */
            var BrendaLopezEmployee = new Employee
            {
                Id = 1,
                Name = "Brenda",
                Surname = "Lopez Reyes",
                BirthDate = new DateTime(1988, 06, 17),
                Email = "BrendaLopez@school.com",
                PhoneNumber = "8445678787",
                CreatedOn = DateTime.Now
            };

            var AlmaRosaEmployee = new Employee
            {
                Id = 2,
                Name = "Alma Rosa",
                Surname = "Aguilar Tejada",
                BirthDate = new DateTime(1980, 05, 15),
                Email = "AlmaRosa@school.com",
                PhoneNumber = "8445567556",
                CreatedOn = DateTime.Now
            };

            var LorenaSuarezEmployee = new Employee
            {
                Id = 3,
                Name = "Lorena",
                Surname = "Suarez Treviño",
                BirthDate = new DateTime(1990, 02, 15),
                Email = "LorenaSuarez@school.com",
                PhoneNumber = "8445552552",
                CreatedOn = DateTime.Now
            };

            var ReginaGonzalesEmployee = new Employee
            {
                Id = 4,
                Name = "Regina",
                Surname = "Gonzales Perreira",
                BirthDate = new DateTime(1981, 08, 10),
                Email = "ReginaGonzales@school.com",
                PhoneNumber = "8446787575",
                CreatedOn = DateTime.Now
            };

            var LuisCarranzaEmployee = new Employee
            {
                Id = 5,
                Name = "Luis",
                Surname = "Carranza Allende",
                BirthDate = new DateTime(1975, 02, 11),
                Email = "LuisCarranza@school.com",
                PhoneNumber = "8445678787",
                CreatedOn = DateTime.Now
            };

            modelBuilder.Entity<Employee>().HasData(BrendaLopezEmployee, AlmaRosaEmployee, LorenaSuarezEmployee, ReginaGonzalesEmployee, LuisCarranzaEmployee);

            /**
             * AreaEmployee
             */
            var areaEmployeeEntity = "AreaEmployee";
            var areaId = "AreasId";
            var employeeId = "EmployeesId";

            modelBuilder.Entity(areaEmployeeEntity).HasData(
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = BrendaLopezEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = AlmaRosaEmployee.Id },
                new Dictionary<string, object> { [areaId] = administrativeArea.Id, [employeeId] = AlmaRosaEmployee.Id },
                new Dictionary<string, object> { [areaId] = administrativeArea.Id, [employeeId] = LorenaSuarezEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = LorenaSuarezEmployee.Id },
                new Dictionary<string, object> { [areaId] = cleaningArea.Id, [employeeId] = ReginaGonzalesEmployee.Id },
                new Dictionary<string, object> { [areaId] = securityGuardArea.Id, [employeeId] = LuisCarranzaEmployee.Id }
            );

            /**
             * Professors
             */
            var BrendaLopezProfessor = new Professor
            {
                Id = 1,
                EmployeeId = BrendaLopezEmployee.Id,
                Satisfaction = 85,
                YearsOnDuty = 5
            };

            var AlmaRosaProfessor = new Professor
            {
                Id = 2,
                EmployeeId = AlmaRosaEmployee.Id,
                Satisfaction = 90,
                YearsOnDuty = 30
            };

            var LorenaProfessor = new Professor
            {
                Id = 3,
                EmployeeId = LorenaSuarezEmployee.Id,
                Satisfaction = 90,
                YearsOnDuty = 15
            };

            modelBuilder.Entity<Professor>().HasData(BrendaLopezProfessor, AlmaRosaProfessor, LorenaProfessor);

            /**
            * Subjects
            */
            var math1 = new Subject
            {
                Id = 1,
                Name = "Matemáticas I",
                AvailableSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.Now
            };

            var math2 = new Subject
            {
                Id = 2,
                Name = "Matemáticas II",
                AvailableSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.Now
            };

            var math3 = new Subject
            {
                Id = 3,
                Name = "Matemáticas III",
                AvailableSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.Now
            };

            var physics1 = new Subject
            {
                Id = 4,
                Name = "Física I",
                AvailableSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.Now
            };

            var physics2 = new Subject
            {
                Id = 5,
                Name = "Física II",
                AvailableSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.Now
            };

            modelBuilder.Entity<Subject>().HasData(math1, math2, math3, physics1, physics2);

            /**
             * ProfessorSubject
             */
            var AlmaRosaMath1 = new ProfessorSubject
            {
                ProfessorId = AlmaRosaProfessor.Id,
                SubjectId = math1.Id
            };

            var AlmaRosaMath2 = new ProfessorSubject
            {
                ProfessorId = AlmaRosaProfessor.Id,
                SubjectId = math2.Id
            };

            var LorenaMath1 = new ProfessorSubject
            {
                ProfessorId = LorenaProfessor.Id,
                SubjectId = math1.Id
            };

            var LorenaMath3 = new ProfessorSubject
            {
                ProfessorId = LorenaProfessor.Id,
                SubjectId = math3.Id
            };

            var BrendaPhysics = new ProfessorSubject
            {
                ProfessorId = BrendaLopezProfessor.Id,
                SubjectId = physics1.Id
            };

            var BrendaPhysics2 = new ProfessorSubject
            {
                ProfessorId = BrendaLopezProfessor.Id,
                SubjectId = physics2.Id
            };

            modelBuilder.Entity<ProfessorSubject>().HasData(AlmaRosaMath1, AlmaRosaMath2, LorenaMath1, LorenaMath3, BrendaPhysics, BrendaPhysics2);

            /**
             * Students
             */
            var emilianoStudent = new Student
            {
                Id = 1,
                Name = "Emiliano",
                Surname = "Salinas",
                BirthDate = new DateTime(2000, 06, 02),
                PhoneNumber = "8445556767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.Now
            };

            var omarStudent = new Student
            {
                Id = 2,
                Name = "Omar",
                Surname = "Reyes",
                BirthDate = new DateTime(2000, 05, 30),
                PhoneNumber = "8445556767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.Now
            };

            var jimenaStudent = new Student
            {
                Id = 3,
                Name = "Jimena",
                Surname = "Trejo",
                BirthDate = new DateTime(2000, 02, 25),
                PhoneNumber = "8442225656",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.Now
            };

            var danielStudent = new Student
            {
                Id = 4,
                Name = "Daniel",
                Surname = "Aranda",
                BirthDate = new DateTime(2000, 11, 09),
                PhoneNumber = "8442225656",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.Now
            };

            var julianStudent = new Student
            {
                Id = 5,
                Name = "Julian",
                Surname = "Torres",
                BirthDate = new DateTime(2000, 07, 09),
                PhoneNumber = "8445676767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.Now
            };

            var veronicaStudent = new Student
            {
                Id = 6,
                Name = "Verónica",
                Surname = "Sánchez",
                BirthDate = new DateTime(2000, 05, 05),
                PhoneNumber = "8446789900",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.Now
            };

            modelBuilder.Entity<Student>().HasData(emilianoStudent, omarStudent, jimenaStudent, danielStudent, julianStudent, veronicaStudent);

            /**
             * StudenSubject
             */
            var emilianoMath1 = new StudentSubject
            {
                StudentId = emilianoStudent.Id,
                SubjectId = math1.Id,
                FirstGrade = 91,
                SecondGrade = 92,
                FinalGrade = 91,
                Status = SubjectGradeStatus.Approved,
                CreatedOn = DateTime.Now
            };

            var omarMath1 = new StudentSubject
            {
                StudentId = omarStudent.Id,
                SubjectId = math1.Id,
                FirstGrade = 71,
                SecondGrade = 45,
                FinalGrade = 58,
                Status = SubjectGradeStatus.NotApproved,
                CreatedOn = DateTime.Now
            };

            var jimenaMath2 = new StudentSubject
            {
                StudentId = jimenaStudent.Id,
                SubjectId = math2.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.Now
            };

            var danielMath2 = new StudentSubject
            {
                StudentId = danielStudent.Id,
                SubjectId = math2.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.Now
            };

            var julianMath3 = new StudentSubject
            {
                StudentId = julianStudent.Id,
                SubjectId = math3.Id,
                FirstGrade = 90,
                SecondGrade = 90,
                FinalGrade = 90,
                Status = SubjectGradeStatus.Approved,
                CreatedOn = DateTime.Now
            };

            var julianPhysics1 = new StudentSubject
            {
                StudentId = julianStudent.Id,
                SubjectId = physics1.Id,
                FirstGrade = 50,
                SecondGrade = 40,
                FinalGrade = 45,
                Status = SubjectGradeStatus.NotApproved,
                CreatedOn = DateTime.Now
            };

            var veronicaPhysics2 = new StudentSubject
            {
                StudentId = veronicaStudent.Id,
                SubjectId = physics2.Id,
                FirstGrade = 80,
                SecondGrade = 80,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.Now
            };

            modelBuilder.Entity<StudentSubject>()
                .HasData(emilianoMath1, omarMath1, jimenaMath2, danielMath2, julianMath3, julianPhysics1, veronicaPhysics2);

            /**
            * Role
            */
            var primaryRole = new Role
            {
                Id = 1,
                Name = "PrimaryRole",
                CreatedOn = DateTime.Now
            };

            var adminRole = new Role
            {
                Id = 2,
                Name = "AdminRole",
                CreatedOn = DateTime.Now
            };

            var standardRole = new Role
            {
                Id = 3,
                Name = "StandardRole",
                CreatedOn = DateTime.Now
            };

            modelBuilder.Entity<Role>().HasData(primaryRole, adminRole, standardRole);
        }
    }
}
