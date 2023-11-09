using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVerifiedAtAndEmailConfirmedConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Users",
                type: "varchar(max)",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(1117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(4755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 498, DateTimeKind.Utc).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 497, DateTimeKind.Utc).AddTicks(3021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 375, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 496, DateTimeKind.Utc).AddTicks(7865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 375, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(6613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 373, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(50),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 373, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 494, DateTimeKind.Utc).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 372, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(8810));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(max)",
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(9724),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(4755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 376, DateTimeKind.Utc).AddTicks(1031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 498, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 375, DateTimeKind.Utc).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 497, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 375, DateTimeKind.Utc).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 496, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 373, DateTimeKind.Utc).AddTicks(9554),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 373, DateTimeKind.Utc).AddTicks(2626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 8, 4, 39, 16, 372, DateTimeKind.Utc).AddTicks(8744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 494, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 8, 4, 39, 16, 377, DateTimeKind.Utc).AddTicks(895));
        }
    }
}
