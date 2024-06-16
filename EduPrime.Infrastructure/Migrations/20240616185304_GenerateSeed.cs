using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class GenerateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(7070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(6020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(3820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(2980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(5760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(2330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Name", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "create:areas", null },
                    { 2, "update:areas", null },
                    { 3, "delete:areas", null },
                    { 4, "get:areas", null },
                    { 5, "create:employees", null },
                    { 6, "update:employees", null },
                    { 7, "delete:employees", null },
                    { 8, "get:employees", null },
                    { 9, "create:professors", null },
                    { 10, "update:professors", null },
                    { 11, "delete:professors", null },
                    { 12, "get:professors", null },
                    { 13, "create:subjects", null },
                    { 14, "update:subjects", null },
                    { 15, "delete:subjects", null },
                    { 16, "get:subjects", null },
                    { 17, "create:students", null },
                    { 18, "update:students", null },
                    { 19, "delete:students", null },
                    { 20, "get:students", null },
                    { 21, "create:users", null },
                    { 22, "update:users", null },
                    { 23, "delete:users", null },
                    { 24, "get:users", null },
                    { 25, "create:roles", null },
                    { 26, "update:roles", null },
                    { 27, "delete:roles", null },
                    { 28, "get:roles", null }
                });

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.InsertData(
                table: "PermissionsRoles",
                columns: new[] { "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 },
                    { 21, 1 },
                    { 22, 1 },
                    { 23, 1 },
                    { 24, 1 },
                    { 25, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 28, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 2 },
                    { 14, 2 },
                    { 15, 2 },
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 24, 2 },
                    { 28, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 3 },
                    { 17, 3 },
                    { 18, 3 },
                    { 19, 3 },
                    { 20, 3 },
                    { 4, 4 },
                    { 8, 4 },
                    { 12, 4 },
                    { 16, 4 },
                    { 20, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 21, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 24, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 26, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 19, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "PermissionsRoles",
                keyColumns: new[] { "PermissionId", "RoleId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(6990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(6020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(3750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(2850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(9940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 3, DateTimeKind.Utc));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Permissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(5170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 16, 2, 38, 42, 946, DateTimeKind.Utc).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 16, 18, 53, 4, 2, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 6, 16, 2, 38, 42, 947, DateTimeKind.Utc).AddTicks(8960));
        }
    }
}
