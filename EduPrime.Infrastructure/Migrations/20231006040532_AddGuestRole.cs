using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGuestRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 929, DateTimeKind.Local).AddTicks(3718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 928, DateTimeKind.Local).AddTicks(9910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(9995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 621, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(4073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8164), "Primary" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8166), "Admim" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8167), "Standard" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedOn", "Name", "UpdatedOn" },
                values: new object[] { 4, new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8169), "Guest", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(7914));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(3741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 930, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(9001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 929, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 622, DateTimeKind.Local).AddTicks(5692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 928, DateTimeKind.Local).AddTicks(9910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 621, DateTimeKind.Local).AddTicks(3418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(5757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 21, 27, 58, 620, DateTimeKind.Local).AddTicks(1894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 22, 5, 31, 927, DateTimeKind.Local).AddTicks(632));

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
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5301), "PrimaryRole" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5303), "AdminRole" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Name" },
                values: new object[] { new DateTime(2023, 10, 3, 21, 27, 58, 624, DateTimeKind.Local).AddTicks(5304), "StandardRole" });

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
    }
}
