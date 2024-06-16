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
             * AREAS
             */
            var professorArea = new Area { Id = 1, Name = "Professor", Description = "Only those who teach a subject", CreatedOn = DateTime.UtcNow };
            var administrativeArea = new Area { Id = 2, Name = "Office administrative", Description = "Office administrative area", CreatedOn = DateTime.UtcNow };
            var cleaningArea = new Area { Id = 3, Name = "Clean service", Description = "School clean service", CreatedOn = DateTime.UtcNow };
            var securityGuardArea = new Area { Id = 4, Name = "Security guard", Description = "School security guard", CreatedOn = DateTime.UtcNow };

            modelBuilder.Entity<Area>().HasData(professorArea, administrativeArea, cleaningArea, securityGuardArea);

            /**
             * EMPLOYEES
             * These are employees that can be assigned to any school area.
             */

            // Professor
            var BrendaLopezEmployee = new Employee
            {
                Id = 1,
                Name = "Brenda",
                Surname = "Lopez Reyes",
                BirthDate = new DateTime(1988, 06, 17),
                Email = "BrendaLopez@school.com",
                PhoneNumber = "8445678787",
                CreatedOn = DateTime.UtcNow
            };

            // Professor
            var AlmaRosaEmployee = new Employee
            {
                Id = 2,
                Name = "Alma Rosa",
                Surname = "Aguilar Tejada",
                BirthDate = new DateTime(1980, 05, 15),
                Email = "AlmaRosa@school.com",
                PhoneNumber = "8445567556",
                CreatedOn = DateTime.UtcNow
            };

            // Professor
            var LorenaSuarezEmployee = new Employee
            {
                Id = 3,
                Name = "Lorena",
                Surname = "Suarez Treviño",
                BirthDate = new DateTime(1990, 02, 15),
                Email = "LorenaSuarez@school.com",
                PhoneNumber = "8445552552",
                CreatedOn = DateTime.UtcNow
            };

            // Professor
            var RamiroTorreroEmployee = new Employee
            {
                Id = 4,
                Name = "Ramiro",
                Surname = "Torrero Salinas",
                BirthDate = new DateTime(1985, 02, 10),
                Email = "RamiroTorrero@school.com",
                PhoneNumber = "8449883834",
                CreatedOn = DateTime.UtcNow
            };

            // Professor
            var MarisolTorresEmployee = new Employee
            {
                Id = 5,
                Name = "Marisol",
                Surname = "Torres Valdés",
                BirthDate = new DateTime(1990, 05, 11),
                Email = "MarisolTorres@school.com",
                PhoneNumber = "8445556781",
                CreatedOn = DateTime.UtcNow
            };

            // Professor
            var SofiaCardenasEmployee = new Employee
            {
                Id = 6,
                Name = "Sofía",
                Surname = "Cárdenas Berrendo",
                BirthDate = new DateTime(1980, 02, 11),
                Email = "SofiaCardenas@school.com",
                PhoneNumber = "8445556781",
                CreatedOn = DateTime.UtcNow
            };

            // Clean service
            var ReginaGonzalesEmployee = new Employee
            {
                Id = 7,
                Name = "Regina",
                Surname = "Gonzales Perreira",
                BirthDate = new DateTime(1981, 08, 10),
                Email = "ReginaGonzales@school.com",
                PhoneNumber = "8446787575",
                CreatedOn = DateTime.UtcNow
            };

            // Clean service
            var VeronicaZertucheEmployee = new Employee
            {
                Id = 8,
                Name = "Verónica",
                Surname = "Zertuche Mora",
                BirthDate = new DateTime(1975, 06, 28),
                Email = "VeronicaZertuche@school.com",
                PhoneNumber = "8449990023",
                CreatedOn = DateTime.UtcNow
            };

            // Security guard service
            var LuisCarranzaEmployee = new Employee
            {
                Id = 9,
                Name = "Luis",
                Surname = "Carranza Allende",
                BirthDate = new DateTime(1975, 02, 11),
                Email = "LuisCarranza@school.com",
                PhoneNumber = "8445678787",
                CreatedOn = DateTime.UtcNow
            };

            modelBuilder.Entity<Employee>().HasData(
                BrendaLopezEmployee,
                AlmaRosaEmployee,
                LorenaSuarezEmployee,
                RamiroTorreroEmployee,
                MarisolTorresEmployee,
                SofiaCardenasEmployee,
                ReginaGonzalesEmployee,
                VeronicaZertucheEmployee,
                LuisCarranzaEmployee
            );

            /**
             * AreaEmployee
             */
            var areaEmployeeEntity = "AreaEmployee";
            var areaId = "AreasId";
            var employeeId = "EmployeesId";

            modelBuilder.Entity(areaEmployeeEntity).HasData(
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = BrendaLopezEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = AlmaRosaEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = RamiroTorreroEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = MarisolTorresEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = SofiaCardenasEmployee.Id },
                new Dictionary<string, object> { [areaId] = professorArea.Id, [employeeId] = LorenaSuarezEmployee.Id },
                new Dictionary<string, object> { [areaId] = administrativeArea.Id, [employeeId] = AlmaRosaEmployee.Id },
                new Dictionary<string, object> { [areaId] = administrativeArea.Id, [employeeId] = LorenaSuarezEmployee.Id },
                new Dictionary<string, object> { [areaId] = cleaningArea.Id, [employeeId] = ReginaGonzalesEmployee.Id },
                new Dictionary<string, object> { [areaId] = cleaningArea.Id, [employeeId] = VeronicaZertucheEmployee.Id },
                new Dictionary<string, object> { [areaId] = securityGuardArea.Id, [employeeId] = LuisCarranzaEmployee.Id }
            );

            /**
             * PROFESSORS
             * A professor needs to be associated with an employee wich must be linked to a professor area.
             */
            var BrendaLopezProfessor = new Professor
            {
                Id = 1,
                EmployeeId = BrendaLopezEmployee.Id,
                Satisfaction = 85,
                YearsOnDuty = 5,
                CreatedOn = DateTime.UtcNow
            };

            var AlmaRosaProfessor = new Professor
            {
                Id = 2,
                EmployeeId = AlmaRosaEmployee.Id,
                Satisfaction = 90,
                YearsOnDuty = 30,
                CreatedOn = DateTime.UtcNow
            };

            var LorenaProfessor = new Professor
            {
                Id = 3,
                EmployeeId = LorenaSuarezEmployee.Id,
                Satisfaction = 90,
                YearsOnDuty = 15,
                CreatedOn = DateTime.UtcNow
            };

            var RamiroProfessor = new Professor
            {
                Id = 4,
                EmployeeId = RamiroTorreroEmployee.Id,
                Satisfaction = 100,
                YearsOnDuty = 10,
                CreatedOn = DateTime.UtcNow
            };

            var MarisolTorresProfessor = new Professor
            {
                Id = 5,
                EmployeeId = MarisolTorresEmployee.Id,
                Satisfaction = 45,
                YearsOnDuty = 3,
                CreatedOn = DateTime.UtcNow
            };

            var SofiaCardenasProfessor = new Professor
            {
                Id = 6,
                EmployeeId = SofiaCardenasEmployee.Id,
                Satisfaction = 100,
                YearsOnDuty = 10,
                CreatedOn = DateTime.UtcNow
            };

            modelBuilder.Entity<Professor>().HasData(
                BrendaLopezProfessor,
                AlmaRosaProfessor,
                LorenaProfessor,
                RamiroProfessor,
                MarisolTorresProfessor,
                SofiaCardenasProfessor
            );

            /**
            * SUBJECTS
            */

            // First semester subjects
            var math1 = new Subject
            {
                Id = 1,
                Name = "Matemáticas I",
                AvailableSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };
            var physics1 = new Subject
            {
                Id = 2,
                Name = "Física I",
                AvailableSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };
            var history = new Subject
            {
                Id = 3,
                Name = "Historia",
                AvailableSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Second semester subjects
            var math2 = new Subject
            {
                Id = 4,
                Name = "Matemáticas II",
                AvailableSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };
            var physics2 = new Subject
            {
                Id = 5,
                Name = "Física II",
                AvailableSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };
            var finance = new Subject
            {
                Id = 6,
                Name = "Finanzas",
                AvailableSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Third semester subjects
            var math3 = new Subject
            {
                Id = 7,
                Name = "Matemáticas III",
                AvailableSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };
            var physics3 = new Subject
            {
                Id = 8,
                Name = "Física III",
                AvailableSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };
            var chemistry = new Subject
            {
                Id = 9,
                Name = "Química I",
                AvailableSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Fourth semester subjects
            var philosophy = new Subject
            {
                Id = 10,
                Name = "Filosofía",
                AvailableSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };
            var computing = new Subject
            {
                Id = 11,
                Name = "Informática",
                AvailableSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };
            var chemistry2 = new Subject
            {
                Id = 12,
                Name = "Química II",
                AvailableSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };

            modelBuilder.Entity<Subject>().HasData(math1, math2, math3, physics1, physics2, physics3, history, finance, chemistry, philosophy, computing, chemistry2);

            /**
             * ProfessorSubject
             */
            var AlmaRosaMath1 = new ProfessorSubject
            {
                ProfessorId = AlmaRosaProfessor.Id,
                SubjectId = math1.Id
            };
            var LorenaMath1 = new ProfessorSubject
            {
                ProfessorId = LorenaProfessor.Id,
                SubjectId = math1.Id
            };

            var AlmaRosaMath2 = new ProfessorSubject
            {
                ProfessorId = AlmaRosaProfessor.Id,
                SubjectId = math2.Id
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

            var RamiroFinance = new ProfessorSubject
            {
                ProfessorId = RamiroProfessor.Id,
                SubjectId = finance.Id
            };

            var MarisolHistory = new ProfessorSubject
            {
                ProfessorId = MarisolTorresProfessor.Id,
                SubjectId = history.Id
            };

            var MarisolPhilosophy = new ProfessorSubject
            {
                ProfessorId = MarisolTorresProfessor.Id,
                SubjectId = philosophy.Id
            };

            var SofiaChemistry = new ProfessorSubject
            {
                ProfessorId = SofiaCardenasProfessor.Id,
                SubjectId = chemistry.Id
            };
            var SofiaChemistry2 = new ProfessorSubject
            {
                ProfessorId = SofiaCardenasProfessor.Id,
                SubjectId = chemistry2.Id
            };

            modelBuilder.Entity<ProfessorSubject>().HasData(
                AlmaRosaMath1,
                AlmaRosaMath2,
                LorenaMath1,
                LorenaMath3,
                BrendaPhysics,
                BrendaPhysics2,
                RamiroFinance,
                MarisolHistory,
                MarisolPhilosophy,
                SofiaChemistry,
                SofiaChemistry2
            );

            /**
             * STUDENTS
             */

            // First semester students
            var emilianoFirstSemesterStudent = new Student
            {
                Id = 1,
                Name = "Emiliano",
                Surname = "Romero Salínas",
                BirthDate = new DateTime(2000, 08, 02),
                PhoneNumber = "8445556767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };
            var omarFirstSemesterStudent = new Student
            {
                Id = 2,
                Name = "Omar",
                Surname = "Martínez Reyes",
                BirthDate = new DateTime(2000, 05, 30),
                PhoneNumber = "8445556767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };
            var veronicaFirstSemesterStudent = new Student
            {
                Id = 3,
                Name = "Verónica",
                Surname = "Sánchez",
                BirthDate = new DateTime(2000, 05, 05),
                PhoneNumber = "8446789900",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FirstSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Second semester students
            var jimenaSecondSemesterStudent = new Student
            {
                Id = 4,
                Name = "Jimena",
                Surname = "Trejo González",
                BirthDate = new DateTime(1999, 02, 25),
                PhoneNumber = "8442225656",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };
            var danielSecondSemesterStudent = new Student
            {
                Id = 5,
                Name = "Daniel",
                Surname = "Aranda Martín",
                BirthDate = new DateTime(1999, 11, 09),
                PhoneNumber = "8442225656",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };
            var valeriaSecondSemesterStudent = new Student
            {
                Id = 6,
                Name = "Valeria",
                Surname = "Guzmán Allende",
                BirthDate = new DateTime(1999, 03, 09),
                PhoneNumber = "8445556776",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.SecondSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Third semester students
            var julianThirdSemesterStudent = new Student
            {
                Id = 7,
                Name = "Julian",
                Surname = "Torres Cabrera",
                BirthDate = new DateTime(1998, 07, 09),
                PhoneNumber = "8445676767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };
            var juanThirdSemesterStudent = new Student
            {
                Id = 8,
                Name = "Juan",
                Surname = "Aguilar Cabello",
                BirthDate = new DateTime(1998, 04, 02),
                PhoneNumber = "8445676767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };
            var gabrielaThirdSemesterStudent = new Student
            {
                Id = 9,
                Name = "Gabriela",
                Surname = "Agustín Neida",
                BirthDate = new DateTime(1998, 01, 18),
                PhoneNumber = "8445676767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.ThirdSemester,
                CreatedOn = DateTime.UtcNow
            };

            // Fourth semester students
            var pedroFourthSemesterStudent = new Student
            {
                Id = 10,
                Name = "Pedro",
                Surname = "Ignácio Carranza",
                BirthDate = new DateTime(1997, 06, 18),
                PhoneNumber = "8445676767",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };
            var amandaFourthSemesterStudent = new Student
            {
                Id = 11,
                Name = "Amanda",
                Surname = "Treviño Almeda",
                BirthDate = new DateTime(1997, 11, 06),
                PhoneNumber = "8445582019",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };
            var jessicaFourthSemesterStudent = new Student
            {
                Id = 12,
                Name = "Jessica",
                Surname = "Ramos Irigoyen",
                BirthDate = new DateTime(1997, 09, 23),
                PhoneNumber = "8445582019",
                EmergencyContact = "8445677676",
                CurrentSemester = SemesterTypeEnum.FourthSemester,
                CreatedOn = DateTime.UtcNow
            };


            modelBuilder.Entity<Student>().HasData(
                emilianoFirstSemesterStudent,
                omarFirstSemesterStudent,
                veronicaFirstSemesterStudent,
                jimenaSecondSemesterStudent,
                danielSecondSemesterStudent,
                valeriaSecondSemesterStudent,
                julianThirdSemesterStudent,
                juanThirdSemesterStudent,
                gabrielaThirdSemesterStudent,
                pedroFourthSemesterStudent,
                amandaFourthSemesterStudent,
                jessicaFourthSemesterStudent
            );

            /**
             * StudenSubject
             */

            // First semester students with their subjects
            var emilianoMath1 = new StudentSubject
            {
                StudentId = emilianoFirstSemesterStudent.Id,
                SubjectId = math1.Id,
                FirstGrade = 91,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var omarMath1 = new StudentSubject
            {
                StudentId = omarFirstSemesterStudent.Id,
                SubjectId = math1.Id,
                FirstGrade = 71,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var veronicaMath1 = new StudentSubject
            {
                StudentId = veronicaFirstSemesterStudent.Id,
                SubjectId = math1.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var emilianoPhysics1 = new StudentSubject
            {
                StudentId = emilianoFirstSemesterStudent.Id,
                SubjectId = physics1.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var omarPhysics1 = new StudentSubject
            {
                StudentId = omarFirstSemesterStudent.Id,
                SubjectId = physics1.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var veronicaPhysics1 = new StudentSubject
            {
                StudentId = veronicaFirstSemesterStudent.Id,
                SubjectId = physics1.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var emilianoHistory = new StudentSubject
            {
                StudentId = emilianoFirstSemesterStudent.Id,
                SubjectId = history.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var omarHistory = new StudentSubject
            {
                StudentId = omarFirstSemesterStudent.Id,
                SubjectId = history.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var veronicaHistory = new StudentSubject
            {
                StudentId = veronicaFirstSemesterStudent.Id,
                SubjectId = history.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };

            // Second semester students with their subjects
            var jimenaMath2 = new StudentSubject
            {
                StudentId = jimenaSecondSemesterStudent.Id,
                SubjectId = math2.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var danielMath2 = new StudentSubject
            {
                StudentId = danielSecondSemesterStudent.Id,
                SubjectId = math2.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var valeriaMath2 = new StudentSubject
            {
                StudentId = valeriaSecondSemesterStudent.Id,
                SubjectId = math2.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var jimenaPhysics2 = new StudentSubject
            {
                StudentId = jimenaSecondSemesterStudent.Id,
                SubjectId = physics2.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var danielPhysics2 = new StudentSubject
            {
                StudentId = danielSecondSemesterStudent.Id,
                SubjectId = physics2.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var valeriaPhysics2 = new StudentSubject
            {
                StudentId = valeriaSecondSemesterStudent.Id,
                SubjectId = physics2.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var jimenaFinance = new StudentSubject
            {
                StudentId = jimenaSecondSemesterStudent.Id,
                SubjectId = finance.Id,
                FirstGrade = 85,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var danielFinance = new StudentSubject
            {
                StudentId = danielSecondSemesterStudent.Id,
                SubjectId = finance.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var valeriaFinance = new StudentSubject
            {
                StudentId = valeriaSecondSemesterStudent.Id,
                SubjectId = finance.Id,
                FirstGrade = 95,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };

            // Third semester students with their subjects
            var julianMath3 = new StudentSubject
            {
                StudentId = julianThirdSemesterStudent.Id,
                SubjectId = math3.Id,
                FirstGrade = 85,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var juanMath3 = new StudentSubject
            {
                StudentId = juanThirdSemesterStudent.Id,
                SubjectId = math3.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var gabrielaMath3 = new StudentSubject
            {
                StudentId = gabrielaThirdSemesterStudent.Id,
                SubjectId = math3.Id,
                FirstGrade = 95,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var julianPhysics3 = new StudentSubject
            {
                StudentId = julianThirdSemesterStudent.Id,
                SubjectId = physics3.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var juanPhysics3 = new StudentSubject
            {
                StudentId = juanThirdSemesterStudent.Id,
                SubjectId = physics3.Id,
                FirstGrade = 87,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var gabrielaPhysics3 = new StudentSubject
            {
                StudentId = gabrielaThirdSemesterStudent.Id,
                SubjectId = physics3.Id,
                FirstGrade = 65,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var julianChemistry = new StudentSubject
            {
                StudentId = julianThirdSemesterStudent.Id,
                SubjectId = chemistry.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var juanChemistry = new StudentSubject
            {
                StudentId = juanThirdSemesterStudent.Id,
                SubjectId = chemistry.Id,
                FirstGrade = 80,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var gabrielaChemistry = new StudentSubject
            {
                StudentId = gabrielaThirdSemesterStudent.Id,
                SubjectId = chemistry.Id,
                FirstGrade = 90,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };

            // Fourth semester students with their subjects
            var pedroPhilosophy = new StudentSubject
            {
                StudentId = pedroFourthSemesterStudent.Id,
                SubjectId = philosophy.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var amandaPhilosophy = new StudentSubject
            {
                StudentId = amandaFourthSemesterStudent.Id,
                SubjectId = philosophy.Id,
                FirstGrade = 70,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var jessicaPhilosophy = new StudentSubject
            {
                StudentId = jessicaFourthSemesterStudent.Id,
                SubjectId = philosophy.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var pedroComputing = new StudentSubject
            {
                StudentId = pedroFourthSemesterStudent.Id,
                SubjectId = computing.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var amandaComputing = new StudentSubject
            {
                StudentId = amandaFourthSemesterStudent.Id,
                SubjectId = computing.Id,
                FirstGrade = 70,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var jessicaComputing = new StudentSubject
            {
                StudentId = jessicaFourthSemesterStudent.Id,
                SubjectId = computing.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var pedroChemistry2 = new StudentSubject
            {
                StudentId = pedroFourthSemesterStudent.Id,
                SubjectId = chemistry2.Id,
                FirstGrade = 50,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var amandaChemistry2 = new StudentSubject
            {
                StudentId = amandaFourthSemesterStudent.Id,
                SubjectId = chemistry2.Id,
                FirstGrade = 70,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };
            var jessicaChemistry2 = new StudentSubject
            {
                StudentId = jessicaFourthSemesterStudent.Id,
                SubjectId = chemistry2.Id,
                FirstGrade = 100,
                SecondGrade = 0,
                FinalGrade = 0,
                Status = SubjectGradeStatus.InProgress,
                CreatedOn = DateTime.UtcNow
            };

            modelBuilder.Entity<StudentSubject>().HasData(
                  emilianoMath1, omarMath1, veronicaMath1,
                  emilianoPhysics1, omarPhysics1, veronicaPhysics1,
                  emilianoHistory, omarHistory, veronicaHistory,
                  jimenaMath2, danielMath2, valeriaMath2,
                  jimenaPhysics2, danielPhysics2, valeriaPhysics2,
                  jimenaFinance, danielFinance, valeriaFinance,
                  julianMath3, juanMath3, gabrielaMath3,
                  julianPhysics3, juanPhysics3, gabrielaPhysics3,
                  julianChemistry, juanChemistry, gabrielaChemistry,
                  pedroPhilosophy, amandaPhilosophy, jessicaPhilosophy,
                  pedroComputing, amandaComputing, jessicaComputing,
                  pedroChemistry2, amandaChemistry2, jessicaChemistry2
            );

            /**
            * Role
            */
            var primaryRole = new Role
            {
                Id = 1,
                Name = "Primary",
                CreatedOn = DateTime.UtcNow
            };

            var adminRole = new Role
            {
                Id = 2,
                Name = "Admim",
                CreatedOn = DateTime.UtcNow
            };

            var standardRole = new Role
            {
                Id = 3,
                Name = "Standard",
                CreatedOn = DateTime.UtcNow
            };

            var guestRole = new Role
            {
                Id = 4,
                Name = "Guest",
                CreatedOn = DateTime.UtcNow
            };

            modelBuilder.Entity<Role>().HasData(primaryRole, adminRole, standardRole, guestRole);

            /**
            * Permission
            */

            // AREAS
            var createAreas = new Permission
            {
                Id = 1,
                Name = "create:areas"
            };

            var updateAreas = new Permission
            {
                Id = 2,
                Name = "update:areas"
            };

            var deleteAreas = new Permission
            {
                Id = 3,
                Name = "delete:areas"
            };

            var getAreas = new Permission
            {
                Id = 4,
                Name = "get:areas"
            };

            // EMPLOYEES
            var createEmployees = new Permission
            {
                Id = 5,
                Name = "create:employees"
            };

            var updateEmployees = new Permission
            {
                Id = 6,
                Name = "update:employees"
            };

            var deleteEmployees = new Permission
            {
                Id = 7,
                Name = "delete:employees"
            };

            var getEmployees = new Permission
            {
                Id = 8,
                Name = "get:employees"
            };

            // PROFESSORS
            var createProfessors = new Permission
            {
                Id = 9,
                Name = "create:professors"
            };

            var updateProfessors = new Permission
            {
                Id = 10,
                Name = "update:professors"
            };

            var deleteProfessors = new Permission
            {
                Id = 11,
                Name = "delete:professors"
            };

            var getProfessors = new Permission
            {
                Id = 12,
                Name = "get:professors"
            };

            // SUBJECTS
            var createSubjects = new Permission
            {
                Id = 13,
                Name = "create:subjects"
            };

            var updateSubjects = new Permission
            {
                Id = 14,
                Name = "update:subjects"
            };

            var deleteSubjects = new Permission
            {
                Id = 15,
                Name = "delete:subjects"
            };

            var getSubjects = new Permission
            {
                Id = 16,
                Name = "get:subjects"
            };

            // STUDENTS
            var createStudents = new Permission
            {
                Id = 17,
                Name = "create:students"
            };

            var updateStudents = new Permission
            {
                Id = 18,
                Name = "update:students"
            };

            var deleteStudents = new Permission
            {
                Id = 19,
                Name = "delete:students"
            };

            var getStudents = new Permission
            {
                Id = 20,
                Name = "get:students"
            };

            // USERS
            var createUsers = new Permission
            {
                Id = 21,
                Name = "create:users"
            };

            var updateUsers = new Permission
            {
                Id = 22,
                Name = "update:users"
            };

            var deleteUsers = new Permission
            {
                Id = 23,
                Name = "delete:users"
            };

            var getUsers = new Permission
            {
                Id = 24,
                Name = "get:users"
            };

             // ROLES
            var createRoles = new Permission
            {
                Id = 25,
                Name = "create:roles"
            };

            var updateRoles = new Permission
            {
                Id = 26,
                Name = "update:roles"
            };

            var deleteRoles = new Permission
            {
                Id = 27,
                Name = "delete:roles"
            };

            var getRoles = new Permission
            {
                Id = 28,
                Name = "get:roles"
            };

             modelBuilder.Entity<Permission>().HasData(
                createAreas,
                updateAreas,
                deleteAreas,
                getAreas,

                createEmployees,
                updateEmployees,
                deleteEmployees,
                getEmployees,

                createProfessors,
                updateProfessors,
                deleteProfessors,
                getProfessors,

                createSubjects,
                updateSubjects,
                deleteSubjects,
                getSubjects,

                createStudents,
                updateStudents,
                deleteStudents,
                getStudents,

                createUsers,
                updateUsers,
                deleteUsers,
                getUsers,

                createRoles,
                updateRoles,
                deleteRoles,
                getRoles
            );

            /**
            * PermissionRole
            */

            // Primary Role
            var primaryRoleCreateAreas = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createAreas.Id
            };
            var primaryRoleUpdateAreas = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateAreas.Id
            };
            var primaryRoleDeleteAreas = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteAreas.Id
            };
             var primaryRoleGetAreas = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getAreas.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateAreas,
                primaryRoleUpdateAreas,
                primaryRoleDeleteAreas,
                primaryRoleGetAreas
            );

            var primaryRoleCreateEmployees = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createEmployees.Id
            };
            var primaryRoleUpdateEmployees = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateEmployees.Id
            };
            var primaryRoleDeleteEmployees = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteEmployees.Id
            };
            var primaryRoleGetEmployees = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getEmployees.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateEmployees,
                primaryRoleUpdateEmployees,
                primaryRoleDeleteEmployees,
                primaryRoleGetEmployees
            );

            var primaryRoleCreateProfessors = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createProfessors.Id
            };
            var primaryRoleUpdateProfessors = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateProfessors.Id
            };
            var primaryRoleDeleteProfessors = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteProfessors.Id
            };
            var primaryRoleGetProfessors = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getProfessors.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateProfessors,
                primaryRoleUpdateProfessors,
                primaryRoleDeleteProfessors,
                primaryRoleGetProfessors
            );

            var primaryRoleCreateSubjects = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createSubjects.Id
            };
            var primaryRoleUpdateSubjects = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateSubjects.Id
            };
            var primaryRoleDeleteSubjects = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteSubjects.Id
            };
            var primaryRoleGetSubjects = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getSubjects.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateSubjects,
                primaryRoleUpdateSubjects,
                primaryRoleDeleteSubjects,
                primaryRoleGetSubjects
            );

            var primaryRoleCreateStudents = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createStudents.Id
            };
            var primaryRoleUpdateStudents = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateStudents.Id
            };
            var primaryRoleDeleteStudents = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteStudents.Id
            };
            var primaryRoleGetStudents = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getStudents.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateStudents,
                primaryRoleUpdateStudents,
                primaryRoleDeleteStudents,
                primaryRoleGetStudents
            );

            var primaryRoleCreateUsers = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createUsers.Id
            };
            var primaryRoleUpdateUsers = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateUsers.Id
            };
            var primaryRoleDeleteUsers = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteUsers.Id
            };
            var primaryRoleGetUsers = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getUsers.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateUsers,
                primaryRoleUpdateUsers,
                primaryRoleDeleteUsers,
                primaryRoleGetUsers
            );

            var primaryRoleCreateRoles = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = createRoles.Id
            };
            var primaryRoleUpdateRoles = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = updateRoles.Id
            };
            var primaryRoleDeleteRoles = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = deleteRoles.Id
            };
            var primaryRoleGetRoles = new PermissionRole
            {
                RoleId = primaryRole.Id,
                PermissionId = getRoles.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                primaryRoleCreateRoles,
                primaryRoleUpdateRoles,
                primaryRoleDeleteRoles,
                primaryRoleGetRoles
            );

            // Admin Role
            var adminRoleCreateAreas = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = createAreas.Id
            };
            var adminRoleUpdateAreas = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = updateAreas.Id
            };
            var adminRoleDeleteAreas = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = deleteAreas.Id
            };
             var adminRoleGetAreas = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getAreas.Id
            };

            var adminRoleCreateEmployees = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = createEmployees.Id
            };
            var adminRoleUpdateEmployees = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = updateEmployees.Id
            };
            var adminRoleDeleteEmployees = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = deleteEmployees.Id
            };
            var adminRoleGetEmployees = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getEmployees.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                adminRoleCreateEmployees,
                adminRoleUpdateEmployees,
                adminRoleDeleteEmployees,
                adminRoleGetEmployees
            );

            var adminRoleCreateProfessors = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = createProfessors.Id
            };
            var adminRoleUpdateProfessors = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = updateProfessors.Id
            };
            var adminRoleDeleteProfessors = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = deleteProfessors.Id
            };
            var adminRoleGetProfessors = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getProfessors.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                adminRoleCreateProfessors,
                adminRoleUpdateProfessors,
                adminRoleDeleteProfessors,
                adminRoleGetProfessors
            );

             var adminRoleCreateSubjects = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = createSubjects.Id
            };
            var adminRoleUpdateSubjects = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = updateSubjects.Id
            };
            var adminRoleDeleteSubjects = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = deleteSubjects.Id
            };
            var adminRoleGetSubjects = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getSubjects.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                adminRoleCreateSubjects,
                adminRoleUpdateSubjects,
                adminRoleDeleteSubjects,
                adminRoleGetSubjects
            );

             var adminRoleCreateStudents = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = createStudents.Id
            };
            var adminRoleUpdateStudents = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = updateStudents.Id
            };
            var adminRoleDeleteStudents = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = deleteStudents.Id
            };
            var adminRoleGetStudents = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getStudents.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                adminRoleCreateStudents,
                adminRoleUpdateStudents,
                adminRoleDeleteStudents,
                adminRoleGetStudents
            );

            var adminRoleGetUsers = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getUsers.Id
            };
            var adminRoleGetRoles = new PermissionRole
            {
                RoleId = adminRole.Id,
                PermissionId = getRoles.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                adminRoleGetUsers,
                adminRoleGetRoles
            );

            // Standard Role
            var standardRoleCreateAreas = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = createAreas.Id
            };
            var standardRoleUpdateAreas = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = updateAreas.Id
            };
            var standardRoleDeleteAreas = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = deleteAreas.Id
            };
             var standardRoleGetAreas = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = getAreas.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                standardRoleCreateAreas,
                standardRoleUpdateAreas,
                standardRoleDeleteAreas,
                standardRoleGetAreas
            );

            var standardRoleCreateEmployees = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = createEmployees.Id
            };
            var standardRoleUpdateEmployees = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = updateEmployees.Id
            };
            var standardRoleDeleteEmployees = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = deleteEmployees.Id
            };
            var standardRoleGetEmployees = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = getEmployees.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                standardRoleCreateEmployees,
                standardRoleUpdateEmployees,
                standardRoleDeleteEmployees,
                standardRoleGetEmployees
            );

            var standardRoleCreateProfessors = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = createProfessors.Id
            };
            var standardRoleUpdateProfessors = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = updateProfessors.Id
            };
            var standardRoleDeleteProfessors = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = deleteProfessors.Id
            };
            var standardRoleGetProfessors = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = getProfessors.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                standardRoleCreateProfessors,
                standardRoleUpdateProfessors,
                standardRoleDeleteProfessors,
                standardRoleGetProfessors
            );

            var standardRoleCreateSubjects = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = createSubjects.Id
            };
            var standardRoleUpdateSubjects = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = updateSubjects.Id
            };
            var standardRoleDeleteSubjects = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = deleteSubjects.Id
            };
            var standardRoleGetSubjects = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = getSubjects.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                standardRoleCreateSubjects,
                standardRoleUpdateSubjects,
                standardRoleDeleteSubjects,
                standardRoleGetSubjects
            );

            var standardRoleCreateStudents = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = createStudents.Id
            };
            var standardRoleUpdateStudents = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = updateStudents.Id
            };
            var standardRoleDeleteStudents = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = deleteStudents.Id
            };
            var standardRoleGetStudents = new PermissionRole
            {
                RoleId = standardRole.Id,
                PermissionId = getStudents.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                standardRoleCreateStudents,
                standardRoleUpdateStudents,
                standardRoleDeleteStudents,
                standardRoleGetStudents
            );

            // Guest Role
            var guestRoleGetAreas = new PermissionRole
            {
                RoleId = guestRole.Id,
                PermissionId = getAreas.Id
            };
            var guestRoleGetEmployees = new PermissionRole
            {
                RoleId = guestRole.Id,
                PermissionId = getEmployees.Id
            };
            var guestRoleGetProfessors = new PermissionRole
            {
                RoleId = guestRole.Id,
                PermissionId = getProfessors.Id
            };
            var guestRoleGetSubjects = new PermissionRole
            {
                RoleId = guestRole.Id,
                PermissionId = getSubjects.Id
            };
            var guestRoleGetStudents = new PermissionRole
            {
                RoleId = guestRole.Id,
                PermissionId = getStudents.Id
            };
            modelBuilder.Entity<PermissionRole>().HasData(
                guestRoleGetAreas,
                guestRoleGetEmployees,
                guestRoleGetProfessors,
                guestRoleGetSubjects,
                guestRoleGetStudents
            );
        }
    }
}
