using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVerificationTokenExpirationTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.AddColumn<DateTime>(
                name: "VerificationTokenExpirationTime",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 731, DateTimeKind.Utc).AddTicks(9354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 731, DateTimeKind.Utc).AddTicks(5062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 498, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 730, DateTimeKind.Utc).AddTicks(7378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 497, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 730, DateTimeKind.Utc).AddTicks(2186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 496, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 728, DateTimeKind.Utc).AddTicks(1628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 727, DateTimeKind.Utc).AddTicks(4974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 727, DateTimeKind.Utc).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 494, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 1, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 2, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 2 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 3, 3 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 4, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 5, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 4 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 5 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 6, 6 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 7, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 8, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 7 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 8 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 9, 9 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 10, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 11, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 10 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 11 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "StudentsSubjects",
                keyColumns: new[] { "StudentId", "SubjectId" },
                keyValues: new object[] { 12, 12 },
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(6010));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationTokenExpirationTime",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(7470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 732, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 499, DateTimeKind.Utc).AddTicks(1117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 731, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "StudentsSubjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 498, DateTimeKind.Utc).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 731, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 497, DateTimeKind.Utc).AddTicks(3021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 730, DateTimeKind.Utc).AddTicks(7378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 496, DateTimeKind.Utc).AddTicks(7865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 730, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Professors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(6613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 728, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 495, DateTimeKind.Utc).AddTicks(50),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 727, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Areas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 9, 1, 47, 43, 494, DateTimeKind.Utc).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 9, 1, 57, 54, 727, DateTimeKind.Utc).AddTicks(1295));

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
    }
}
