using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 389, DateTimeKind.Local).AddTicks(8857)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PictureURL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    RfcDocument = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 390, DateTimeKind.Local).AddTicks(2183)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 391, DateTimeKind.Local).AddTicks(7164)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: true),
                    PictureURL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EmergencyContact = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CurrentSemester = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 392, DateTimeKind.Local).AddTicks(1569)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AvailableSemester = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 393, DateTimeKind.Local).AddTicks(9266)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaEmployee",
                columns: table => new
                {
                    AreasId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEmployee", x => new { x.AreasId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_AreaEmployee_Areas_AreasId",
                        column: x => x.AreasId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreaEmployee_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Satisfaction = table.Column<int>(type: "int", maxLength: 100, nullable: false, defaultValue: 0),
                    YearsOnDuty = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(3587)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSubjects",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    FirstGrade = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SecondGrade = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FinalGrade = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessorsSubjects",
                columns: table => new
                {
                    ProfessorId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessorsSubjects", x => new { x.ProfessorId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_ProfessorsSubjects_Professors_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessorsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CreatedOn", "Description", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4250), "Only those who teach a subject", "Professor", null },
                    { 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4253), "Office administrative area", "Office administrative", null },
                    { 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4254), "School clean service", "Clean service", null },
                    { 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4255), "School security guard", "Security guard", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "Email", "Name", "PhoneNumber", "PictureURL", "RfcDocument", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4481), "BrendaLopez@school.com", "Brenda", "8445678787", null, null, "Lopez Reyes", null },
                    { 2, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4485), "AlmaRosa@school.com", "Alma Rosa", "8445567556", null, null, "Aguilar Tejada", null },
                    { 3, new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4487), "LorenaSuarez@school.com", "Lorena", "8445552552", null, null, "Suarez Treviño", null },
                    { 4, new DateTime(1985, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4489), "RamiroTorrero@school.com", "Ramiro", "8449883834", null, null, "Torrero Salinas", null },
                    { 5, new DateTime(1990, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4543), "MarisolTorres@school.com", "Marisol", "8445556781", null, null, "Torres Valdés", null },
                    { 6, new DateTime(1980, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4545), "SofiaCardenas@school.com", "Sofía", "8445556781", null, null, "Cárdenas Berrendo", null },
                    { 7, new DateTime(1981, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4547), "ReginaGonzales@school.com", "Regina", "8446787575", null, null, "Gonzales Perreira", null },
                    { 8, new DateTime(1975, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4549), "VeronicaZertuche@school.com", "Verónica", "8449990023", null, null, "Zertuche Mora", null },
                    { 9, new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4550), "LuisCarranza@school.com", "Luis", "8445678787", null, null, "Carranza Allende", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(5022), "PrimaryRole", null },
                    { 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(5024), "AdminRole", null },
                    { 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(5025), "StandardRole", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "CurrentSemester", "EmergencyContact", "Name", "PhoneNumber", "PictureURL", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4769), 1, "8445677676", "Emiliano", "8445556767", null, "Romero Salínas", null },
                    { 2, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4864), 1, "8445677676", "Omar", "8445556767", null, "Martínez Reyes", null },
                    { 3, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4866), 1, "8445677676", "Verónica", "8446789900", null, "Sánchez", null },
                    { 4, new DateTime(1999, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4869), 2, "8445677676", "Jimena", "8442225656", null, "Trejo González", null },
                    { 5, new DateTime(1999, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4871), 2, "8445677676", "Daniel", "8442225656", null, "Aranda Martín", null },
                    { 6, new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4873), 2, "8445677676", "Valeria", "8445556776", null, "Guzmán Allende", null },
                    { 7, new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4874), 3, "8445677676", "Julian", "8445676767", null, "Torres Cabrera", null },
                    { 8, new DateTime(1998, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4876), 3, "8445677676", "Juan", "8445676767", null, "Aguilar Cabello", null },
                    { 9, new DateTime(1998, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4878), 3, "8445677676", "Gabriela", "8445676767", null, "Agustín Neida", null },
                    { 10, new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4880), 4, "8445677676", "Pedro", "8445676767", null, "Ignácio Carranza", null },
                    { 11, new DateTime(1997, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4883), 4, "8445677676", "Amanda", "8445582019", null, "Treviño Almeda", null },
                    { 12, new DateTime(1997, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4886), 4, "8445677676", "Jessica", "8445582019", null, "Ramos Irigoyen", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "AvailableSemester", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4691), "Matemáticas I", null },
                    { 2, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4693), "Física I", null },
                    { 3, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4694), "Historia", null },
                    { 4, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4695), "Matemáticas II", null },
                    { 5, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4697), "Física II", null },
                    { 6, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4698), "Finanzas", null },
                    { 7, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4699), "Matemáticas III", null },
                    { 8, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4700), "Física III", null },
                    { 9, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4701), "Química I", null },
                    { 10, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4703), "Filosofía", null },
                    { 11, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4704), "Informática", null },
                    { 12, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4705), "Química II", null }
                });

            migrationBuilder.InsertData(
                table: "AreaEmployee",
                columns: new[] { "AreasId", "EmployeesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "EmployeeId", "Satisfaction", "YearsOnDuty" },
                values: new object[,]
                {
                    { 1, 1, 85, 5 },
                    { 2, 2, 90, 30 },
                    { 3, 3, 90, 15 },
                    { 4, 4, 100, 10 },
                    { 5, 5, 45, 3 },
                    { 6, 6, 100, 10 }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4917), 91, null },
                    { 1, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4924), 90, null },
                    { 1, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4931), 90, null },
                    { 2, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4920), 71, null },
                    { 2, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4926), 50, null },
                    { 2, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4932), 50, null },
                    { 3, 1, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4922), 80, null },
                    { 3, 2, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4929), 80, null },
                    { 3, 3, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4935), 80, null },
                    { 4, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4937), 90, null },
                    { 4, 5, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4942), 90, null },
                    { 4, 6, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4948), 85, null },
                    { 5, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4938), 50, null },
                    { 5, 5, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4944), 50, null },
                    { 5, 6, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4950), 100, null },
                    { 6, 4, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4940), 80, null },
                    { 6, 5, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4946), 80, null },
                    { 6, 6, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4952), 95, null },
                    { 7, 7, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4954), 85, null },
                    { 7, 8, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4960), 90, null },
                    { 7, 9, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4965), 100, null },
                    { 8, 7, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4956), 100, null },
                    { 8, 8, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4961), 87, null },
                    { 8, 9, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4966), 80, null },
                    { 9, 7, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4958), 95, null },
                    { 9, 8, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4963), 65, null },
                    { 9, 9, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4968), 90, null },
                    { 10, 10, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4970), 50, null },
                    { 10, 11, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4975), 50, null },
                    { 10, 12, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4981), 50, null },
                    { 11, 10, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4972), 70, null },
                    { 11, 11, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4977), 70, null },
                    { 11, 12, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4984), 70, null },
                    { 12, 10, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4973), 100, null },
                    { 12, 11, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4979), 100, null },
                    { 12, 12, new DateTime(2023, 9, 23, 22, 54, 5, 394, DateTimeKind.Local).AddTicks(4986), 100, null }
                });

            migrationBuilder.InsertData(
                table: "ProfessorsSubjects",
                columns: new[] { "ProfessorId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 7 },
                    { 4, 6 },
                    { 5, 3 },
                    { 5, 10 },
                    { 6, 9 },
                    { 6, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaEmployee_EmployeesId",
                table: "AreaEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_EmployeeId",
                table: "Professors",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessorsSubjects_SubjectId",
                table: "ProfessorsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_SubjectId",
                table: "StudentsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaEmployee");

            migrationBuilder.DropTable(
                name: "ProfessorsSubjects");

            migrationBuilder.DropTable(
                name: "StudentsSubjects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
