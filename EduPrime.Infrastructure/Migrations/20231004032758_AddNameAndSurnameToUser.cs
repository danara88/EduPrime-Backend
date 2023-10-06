using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNameAndSurnameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(3741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 174, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(5692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 173, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 621, DateTimeKind.Local).AddTicks(3418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 172, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 172, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(1894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 171, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(4962));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(5437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(2718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 174, DateTimeKind.Local).AddTicks(2434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 173, DateTimeKind.Local).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 172, DateTimeKind.Local).AddTicks(9243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 621, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 172, DateTimeKind.Local).AddTicks(3084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 19, 50, 28, 171, DateTimeKind.Local).AddTicks(9648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 30, 19, 50, 28, 175, DateTimeKind.Local).AddTicks(6554));
        }
    }
}
