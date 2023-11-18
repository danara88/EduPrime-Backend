using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConfirmEmailFieldForUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(3542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 784, DateTimeKind.Utc).AddTicks(3256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 783, DateTimeKind.Utc).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 367, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 781, DateTimeKind.Utc).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 366, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 780, DateTimeKind.Utc).AddTicks(2145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 366, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 777, DateTimeKind.Utc).AddTicks(8087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 365, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 776, DateTimeKind.Utc).AddTicks(3444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 364, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 775, DateTimeKind.Utc).AddTicks(3115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 364, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(6508));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 785, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 784, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 367, DateTimeKind.Utc).AddTicks(6668),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 783, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 366, DateTimeKind.Utc).AddTicks(9231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 781, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 366, DateTimeKind.Utc).AddTicks(5826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 780, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 365, DateTimeKind.Utc).AddTicks(4939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 777, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 364, DateTimeKind.Utc).AddTicks(8567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 776, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 11, 1, 52, 15, 364, DateTimeKind.Utc).AddTicks(4675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 3, 29, 59, 775, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 11, 1, 52, 15, 368, DateTimeKind.Utc).AddTicks(6483));
        }
    }
}
