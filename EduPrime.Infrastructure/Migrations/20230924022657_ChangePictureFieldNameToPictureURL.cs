using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangePictureFieldNameToPictureURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Students",
                newName: "PictureURL");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(6516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(3789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 766, DateTimeKind.Local).AddTicks(5084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 766, DateTimeKind.Local).AddTicks(1965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 764, DateTimeKind.Local).AddTicks(6388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 764, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(7445));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureURL",
                table: "Students",
                newName: "Picture");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(9756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(7083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 767, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(8325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 766, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(5142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 766, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(5418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 764, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(2050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 23, 20, 26, 56, 764, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(706));
        }
    }
}
