using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(3659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 335, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 376, DateTimeKind.Local).AddTicks(3328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 334, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 375, DateTimeKind.Local).AddTicks(2592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 332, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 374, DateTimeKind.Local).AddTicks(9218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 332, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4246), "Only those who teach a subject", "Professor", null },
                    { 2, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4305), "Office administrative area", "Office administrative", null },
                    { 3, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4307), "School clean service", "Clean service", null },
                    { 4, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4308), "School security guard", "Security guard", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "Email", "Name", "PhoneNumber", "Picture", "RfcDocument", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4494), "BrendaLopez@school.com", "Brenda", "8445678787", null, null, "Lopez Reyes", null },
                    { 2, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4497), "AlmaRosa@school.com", "Alma Rosa", "8445567556", null, null, "Aguilar Tejada", null },
                    { 3, new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4500), "LorenaSuarez@school.com", "Lorena", "8445552552", null, null, "Suarez Treviño", null },
                    { 4, new DateTime(1981, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4502), "ReginaGonzales@school.com", "Regina", "8446787575", null, null, "Gonzales Perreira", null },
                    { 5, new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4504), "LuisCarranza@school.com", "Luis", "8445678787", null, null, "Carranza Allende", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4749), "PrimaryRole", null },
                    { 2, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4751), "AdminRole", null },
                    { 3, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4752), "StandardRole", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "CurrentSemester", "EmergencyContact", "Name", "PhoneNumber", "Picture", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4681), 1, "8445677676", "Emiliano", "8445556767", null, "Salinas", null },
                    { 2, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4684), 1, "8445677676", "Omar", "8445556767", null, "Reyes", null },
                    { 3, new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4686), 2, "8445677676", "Jimena", "8442225656", null, "Trejo", null },
                    { 4, new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4688), 2, "8445677676", "Daniel", "8442225656", null, "Aranda", null },
                    { 5, new DateTime(2000, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4690), 3, "8445677676", "Julian", "8445676767", null, "Torres", null },
                    { 6, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4692), 1, "8445677676", "Verónica", "8446789900", null, "Sánchez", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "AvailableSemester", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4623), "Matemáticas I", null },
                    { 2, 2, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4625), "Matemáticas II", null },
                    { 3, 3, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4626), "Matemáticas III", null },
                    { 4, 3, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4628), "Física I", null },
                    { 5, 4, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4629), "Física II", null }
                });

            migrationBuilder.InsertData(
                table: "AreaEmployee",
                columns: new[] { "AreasId", "EmployeesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "EmployeeId", "Satisfaction", "YearsOnDuty" },
                values: new object[,]
                {
                    { 1, 1, 85, 5 },
                    { 2, 2, 90, 30 },
                    { 3, 3, 90, 15 }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FinalGrade", "FirstGrade", "SecondGrade", "Status", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4715), 91, 91, 92, 1, null },
                    { 2, 1, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4717), 58, 71, 45, 2, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4719), 90, null },
                    { 4, 2, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4721), 100, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FinalGrade", "FirstGrade", "SecondGrade", "Status", "UpdatedOn" },
                values: new object[,]
                {
                    { 5, 3, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4723), 90, 90, 90, 1, null },
                    { 5, 4, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4725), 45, 50, 40, 2, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "SecondGrade", "UpdatedOn" },
                values: new object[] { 6, 5, new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(4727), 80, 80, null });

            migrationBuilder.InsertData(
                table: "ProfessorsSubjects",
                columns: new[] { "ProfessorId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AreaEmployee",
                keyColumns: new[] { "AreasId", "EmployeesId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessorsSubjects",
                keyColumns: new[] { "ProfessorId", "SubjectId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 335, DateTimeKind.Local).AddTicks(6034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 378, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 334, DateTimeKind.Local).AddTicks(1453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 376, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 332, DateTimeKind.Local).AddTicks(7542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 375, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 13, 15, 43, 58, 332, DateTimeKind.Local).AddTicks(3938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 13, 15, 45, 9, 374, DateTimeKind.Local).AddTicks(9218));
        }
    }
}
