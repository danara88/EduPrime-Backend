using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 7, 19, 26, 39, 169, DateTimeKind.Local).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 7, 19, 23, 20, 815, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 7, 19, 26, 39, 167, DateTimeKind.Local).AddTicks(2155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 7, 19, 23, 20, 812, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(130), "Only those who teach a subject", "Professor", null },
                    { 2, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(137), "Office administrative area", "Office administrative", null },
                    { 3, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(138), "School clean service", "Clean service", null },
                    { 4, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(140), "School security guard", "Security guard", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "Email", "Name", "PhoneNumber", "Picture", "RfcDocument", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(576), "BrendaLopez@school.com", "Brenda", "8445678787", null, null, "Lopez Reyes", null },
                    { 2, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(582), "AlmaRosa@school.com", "Alma Rosa", "8445567556", null, null, "Aguilar Tejada", null },
                    { 3, new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(585), "LorenaSuarez@school.com", "Lorena", "8445552552", null, null, "Suarez Treviño", null },
                    { 4, new DateTime(1981, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(587), "ReginaGonzales@school.com", "Regina", "8446787575", null, null, "Gonzales Perreira", null },
                    { 5, new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(590), "LuisCarranza@school.com", "Luis", "8445678787", null, null, "Carranza Allende", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(1020), "PrimaryRole", null },
                    { 2, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(1023), "AdminRole", null },
                    { 3, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(1025), "StandardRole", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "CurrentSemester", "EmergencyContact", "Name", "PhoneNumber", "Picture", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(831), 1, "8445677676", "Emiliano", "8445556767", null, "Salinas", null },
                    { 2, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(835), 1, "8445677676", "Omar", "8445556767", null, "Reyes", null },
                    { 3, new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(908), 2, "8445677676", "Jimena", "8442225656", null, "Trejo", null },
                    { 4, new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(910), 2, "8445677676", "Daniel", "8442225656", null, "Aranda", null },
                    { 5, new DateTime(2000, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(913), 3, "8445677676", "Julian", "8445676767", null, "Torres", null },
                    { 6, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(915), 1, "8445677676", "Verónica", "8446789900", null, "Sánchez", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "AvailableSemester", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(740), "Matemáticas I", null },
                    { 2, 2, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(743), "Matemáticas II", null },
                    { 3, 3, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(745), "Matemáticas III", null },
                    { 4, 3, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(746), "Física I", null },
                    { 5, 4, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(749), "Física II", null }
                });

            migrationBuilder.InsertData(
                table: "AreasEmployees",
                columns: new[] { "AreaId", "EmployeeId" },
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
                    { 1, 1, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(968), 91, 91, 92, 1, null },
                    { 2, 1, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(971), 58, 71, 45, 2, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "UpdatedOn" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(973), 90, null },
                    { 4, 2, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(976), 100, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FinalGrade", "FirstGrade", "SecondGrade", "Status", "UpdatedOn" },
                values: new object[,]
                {
                    { 5, 3, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(978), 90, 90, 90, 1, null },
                    { 5, 4, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(980), 45, 50, 40, 2, null }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "SecondGrade", "UpdatedOn" },
                values: new object[] { 6, 5, new DateTime(2023, 7, 7, 19, 26, 39, 170, DateTimeKind.Local).AddTicks(982), 80, 80, null });

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
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AreasEmployees",
                keyColumns: new[] { "AreaId", "EmployeeId" },
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
                defaultValue: new DateTime(2023, 7, 7, 19, 23, 20, 815, DateTimeKind.Local).AddTicks(5841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 7, 19, 26, 39, 169, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 7, 19, 23, 20, 812, DateTimeKind.Local).AddTicks(3603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 7, 19, 26, 39, 167, DateTimeKind.Local).AddTicks(2155));
        }
    }
}
