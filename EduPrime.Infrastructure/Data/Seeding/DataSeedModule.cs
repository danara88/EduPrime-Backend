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

            modelBuilder.Entity<ProfessorSubject>().HasData(AlmaRosaMath1, AlmaRosaMath2, LorenaMath1, LorenaMath3, BrendaPhysics, BrendaPhysics2, RamiroFinance, MarisolHistory, MarisolPhilosophy, SofiaChemistry, SofiaChemistry2);

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
        }
    }
}
