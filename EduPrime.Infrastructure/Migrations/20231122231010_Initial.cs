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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 312, DateTimeKind.Utc).AddTicks(9801)),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 313, DateTimeKind.Utc).AddTicks(3653)),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 314, DateTimeKind.Utc).AddTicks(9885)),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 315, DateTimeKind.Utc).AddTicks(3217)),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(3559)),
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
                    YearsOnDuty = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 313, DateTimeKind.Utc).AddTicks(9822)),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VerificationToken = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    VerificationTokenExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9018)),
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 22, 23, 10, 10, 315, DateTimeKind.Utc).AddTicks(9974)),
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
                    { 1, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9568), "Only those who teach a subject", "Professor", null },
                    { 2, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9571), "Office administrative area", "Office administrative", null },
                    { 3, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9572), "School clean service", "Clean service", null },
                    { 4, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9573), "School security guard", "Security guard", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "Email", "Name", "PhoneNumber", "PictureURL", "RfcDocument", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9787), "BrendaLopez@school.com", "Brenda", "8445678787", null, null, "Lopez Reyes", null },
                    { 2, new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9789), "AlmaRosa@school.com", "Alma Rosa", "8445567556", null, null, "Aguilar Tejada", null },
                    { 3, new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9791), "LorenaSuarez@school.com", "Lorena", "8445552552", null, null, "Suarez Treviño", null },
                    { 4, new DateTime(1985, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9793), "RamiroTorrero@school.com", "Ramiro", "8449883834", null, null, "Torrero Salinas", null },
                    { 5, new DateTime(1990, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9795), "MarisolTorres@school.com", "Marisol", "8445556781", null, null, "Torres Valdés", null },
                    { 6, new DateTime(1980, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9797), "SofiaCardenas@school.com", "Sofía", "8445556781", null, null, "Cárdenas Berrendo", null },
                    { 7, new DateTime(1981, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9799), "ReginaGonzales@school.com", "Regina", "8446787575", null, null, "Gonzales Perreira", null },
                    { 8, new DateTime(1975, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9800), "VeronicaZertuche@school.com", "Verónica", "8449990023", null, null, "Zertuche Mora", null },
                    { 9, new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9802), "LuisCarranza@school.com", "Luis", "8445678787", null, null, "Carranza Allende", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(249), "Primary", null },
                    { 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(250), "Admim", null },
                    { 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(251), "Standard", null },
                    { 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(252), "Guest", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "CreatedOn", "CurrentSemester", "EmergencyContact", "Name", "PhoneNumber", "PictureURL", "Surname", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(106), 1, "8445677676", "Emiliano", "8445556767", null, "Romero Salínas", null },
                    { 2, new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(108), 1, "8445677676", "Omar", "8445556767", null, "Martínez Reyes", null },
                    { 3, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(110), 1, "8445677676", "Verónica", "8446789900", null, "Sánchez", null },
                    { 4, new DateTime(1999, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(112), 2, "8445677676", "Jimena", "8442225656", null, "Trejo González", null },
                    { 5, new DateTime(1999, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(114), 2, "8445677676", "Daniel", "8442225656", null, "Aranda Martín", null },
                    { 6, new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(116), 2, "8445677676", "Valeria", "8445556776", null, "Guzmán Allende", null },
                    { 7, new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(117), 3, "8445677676", "Julian", "8445676767", null, "Torres Cabrera", null },
                    { 8, new DateTime(1998, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(119), 3, "8445677676", "Juan", "8445676767", null, "Aguilar Cabello", null },
                    { 9, new DateTime(1998, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(121), 3, "8445677676", "Gabriela", "8445676767", null, "Agustín Neida", null },
                    { 10, new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(124), 4, "8445677676", "Pedro", "8445676767", null, "Ignácio Carranza", null },
                    { 11, new DateTime(1997, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(126), 4, "8445677676", "Amanda", "8445582019", null, "Treviño Almeda", null },
                    { 12, new DateTime(1997, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(128), 4, "8445677676", "Jessica", "8445582019", null, "Ramos Irigoyen", null }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "AvailableSemester", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(8), "Matemáticas I", null },
                    { 2, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(9), "Física I", null },
                    { 3, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(11), "Historia", null },
                    { 4, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(12), "Matemáticas II", null },
                    { 5, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(13), "Física II", null },
                    { 6, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(18), "Finanzas", null },
                    { 7, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(19), "Matemáticas III", null },
                    { 8, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(22), "Física III", null },
                    { 9, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(27), "Química I", null },
                    { 10, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(28), "Filosofía", null },
                    { 11, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(29), "Informática", null },
                    { 12, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(30), "Química II", null }
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
                columns: new[] { "Id", "CreatedOn", "EmployeeId", "Satisfaction", "UpdatedOn", "YearsOnDuty" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9911), 1, 85, null, 5 },
                    { 2, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9912), 2, 90, null, 30 },
                    { 3, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9914), 3, 90, null, 15 },
                    { 4, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9915), 4, 100, null, 10 },
                    { 5, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9916), 5, 45, null, 3 },
                    { 6, new DateTime(2023, 11, 22, 23, 10, 10, 316, DateTimeKind.Utc).AddTicks(9917), 6, 100, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId", "CreatedOn", "FirstGrade", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(151), 91, null },
                    { 1, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(156), 90, null },
                    { 1, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(161), 90, null },
                    { 2, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(153), 71, null },
                    { 2, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(158), 50, null },
                    { 2, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(163), 50, null },
                    { 3, 1, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(155), 80, null },
                    { 3, 2, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(160), 80, null },
                    { 3, 3, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(164), 80, null },
                    { 4, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(166), 90, null },
                    { 4, 5, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(171), 90, null },
                    { 4, 6, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(176), 85, null },
                    { 5, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(168), 50, null },
                    { 5, 5, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(173), 50, null },
                    { 5, 6, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(177), 100, null },
                    { 6, 4, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(169), 80, null },
                    { 6, 5, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(174), 80, null },
                    { 6, 6, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(179), 95, null },
                    { 7, 7, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(181), 85, null },
                    { 7, 8, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(186), 90, null },
                    { 7, 9, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(191), 100, null },
                    { 8, 7, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(182), 100, null },
                    { 8, 8, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(187), 87, null },
                    { 8, 9, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(194), 80, null },
                    { 9, 7, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(184), 95, null },
                    { 9, 8, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(189), 65, null },
                    { 9, 9, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(197), 90, null },
                    { 10, 10, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(199), 50, null },
                    { 10, 11, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(204), 50, null },
                    { 10, 12, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(208), 50, null },
                    { 11, 10, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(200), 70, null },
                    { 11, 11, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(205), 70, null },
                    { 11, 12, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(210), 70, null },
                    { 12, 10, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(202), 100, null },
                    { 12, 11, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(207), 100, null },
                    { 12, 12, new DateTime(2023, 11, 22, 23, 10, 10, 317, DateTimeKind.Utc).AddTicks(212), 100, null }
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
