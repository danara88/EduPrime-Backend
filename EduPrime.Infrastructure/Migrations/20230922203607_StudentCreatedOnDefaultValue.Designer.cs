﻿// <auto-generated />
using System;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduPrime.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922203607_StudentCreatedOnDefaultValue")]
    partial class StudentCreatedOnDefaultValue
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AreaEmployee", b =>
                {
                    b.Property<int>("AreasId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("AreasId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("AreaEmployee");

                    b.HasData(
                        new
                        {
                            AreasId = 1,
                            EmployeesId = 1
                        },
                        new
                        {
                            AreasId = 1,
                            EmployeesId = 2
                        },
                        new
                        {
                            AreasId = 2,
                            EmployeesId = 2
                        },
                        new
                        {
                            AreasId = 2,
                            EmployeesId = 3
                        },
                        new
                        {
                            AreasId = 1,
                            EmployeesId = 3
                        },
                        new
                        {
                            AreasId = 3,
                            EmployeesId = 4
                        },
                        new
                        {
                            AreasId = 4,
                            EmployeesId = 5
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(2050));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(317),
                            Description = "Only those who teach a subject",
                            Name = "Professor"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(320),
                            Description = "Office administrative area",
                            Name = "Office administrative"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(322),
                            Description = "School clean service",
                            Name = "Clean service"
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(323),
                            Description = "School security guard",
                            Name = "Security guard"
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 622, DateTimeKind.Local).AddTicks(5418));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("PictureURL")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("RfcDocument")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1988, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(527),
                            Email = "BrendaLopez@school.com",
                            Name = "Brenda",
                            PhoneNumber = "8445678787",
                            Surname = "Lopez Reyes"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(531),
                            Email = "AlmaRosa@school.com",
                            Name = "Alma Rosa",
                            PhoneNumber = "8445567556",
                            Surname = "Aguilar Tejada"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1990, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(533),
                            Email = "LorenaSuarez@school.com",
                            Name = "Lorena",
                            PhoneNumber = "8445552552",
                            Surname = "Suarez Treviño"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1981, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(534),
                            Email = "ReginaGonzales@school.com",
                            Name = "Regina",
                            PhoneNumber = "8446787575",
                            Surname = "Gonzales Perreira"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1975, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(536),
                            Email = "LuisCarranza@school.com",
                            Name = "Luis",
                            PhoneNumber = "8445678787",
                            Surname = "Carranza Allende"
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Satisfaction")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("YearsOnDuty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Professors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            Satisfaction = 85,
                            YearsOnDuty = 5
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 2,
                            Satisfaction = 90,
                            YearsOnDuty = 30
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 3,
                            Satisfaction = 90,
                            YearsOnDuty = 15
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.ProfessorSubject", b =>
                {
                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("ProfessorId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("ProfessorsSubjects");

                    b.HasData(
                        new
                        {
                            ProfessorId = 2,
                            SubjectId = 1
                        },
                        new
                        {
                            ProfessorId = 2,
                            SubjectId = 2
                        },
                        new
                        {
                            ProfessorId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            ProfessorId = 3,
                            SubjectId = 3
                        },
                        new
                        {
                            ProfessorId = 1,
                            SubjectId = 4
                        },
                        new
                        {
                            ProfessorId = 1,
                            SubjectId = 5
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(5142));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(826),
                            Name = "PrimaryRole"
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(827),
                            Name = "AdminRole"
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(828),
                            Name = "StandardRole"
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 624, DateTimeKind.Local).AddTicks(8325));

                    b.Property<int>("CurrentSemester")
                        .HasColumnType("int");

                    b.Property<string>("EmergencyContact")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Picture")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Surname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(760),
                            CurrentSemester = 1,
                            EmergencyContact = "8445677676",
                            Name = "Emiliano",
                            PhoneNumber = "8445556767",
                            Surname = "Salinas"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(763),
                            CurrentSemester = 1,
                            EmergencyContact = "8445677676",
                            Name = "Omar",
                            PhoneNumber = "8445556767",
                            Surname = "Reyes"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(765),
                            CurrentSemester = 2,
                            EmergencyContact = "8445677676",
                            Name = "Jimena",
                            PhoneNumber = "8442225656",
                            Surname = "Trejo"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2000, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(767),
                            CurrentSemester = 2,
                            EmergencyContact = "8445677676",
                            Name = "Daniel",
                            PhoneNumber = "8442225656",
                            Surname = "Aranda"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2000, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(769),
                            CurrentSemester = 3,
                            EmergencyContact = "8445677676",
                            Name = "Julian",
                            PhoneNumber = "8445676767",
                            Surname = "Torres"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(771),
                            CurrentSemester = 1,
                            EmergencyContact = "8445677676",
                            Name = "Verónica",
                            PhoneNumber = "8446789900",
                            Surname = "Sánchez"
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.StudentSubject", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FinalGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("FirstGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("SecondGrade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentsSubjects");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            SubjectId = 1,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(794),
                            FinalGrade = 91,
                            FirstGrade = 91,
                            SecondGrade = 92,
                            Status = 1
                        },
                        new
                        {
                            StudentId = 2,
                            SubjectId = 1,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(796),
                            FinalGrade = 58,
                            FirstGrade = 71,
                            SecondGrade = 45,
                            Status = 2
                        },
                        new
                        {
                            StudentId = 3,
                            SubjectId = 2,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(798),
                            FinalGrade = 0,
                            FirstGrade = 90,
                            SecondGrade = 0,
                            Status = 0
                        },
                        new
                        {
                            StudentId = 4,
                            SubjectId = 2,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(800),
                            FinalGrade = 0,
                            FirstGrade = 100,
                            SecondGrade = 0,
                            Status = 0
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 3,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(801),
                            FinalGrade = 90,
                            FirstGrade = 90,
                            SecondGrade = 90,
                            Status = 1
                        },
                        new
                        {
                            StudentId = 5,
                            SubjectId = 4,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(803),
                            FinalGrade = 45,
                            FirstGrade = 50,
                            SecondGrade = 40,
                            Status = 2
                        },
                        new
                        {
                            StudentId = 6,
                            SubjectId = 5,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(805),
                            FinalGrade = 0,
                            FirstGrade = 80,
                            SecondGrade = 80,
                            Status = 0
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableSemester")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(7083));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableSemester = 1,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(701),
                            Name = "Matemáticas I"
                        },
                        new
                        {
                            Id = 2,
                            AvailableSemester = 2,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(702),
                            Name = "Matemáticas II"
                        },
                        new
                        {
                            Id = 3,
                            AvailableSemester = 3,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(704),
                            Name = "Matemáticas III"
                        },
                        new
                        {
                            Id = 4,
                            AvailableSemester = 3,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(705),
                            Name = "Física I"
                        },
                        new
                        {
                            Id = 5,
                            AvailableSemester = 4,
                            CreatedOn = new DateTime(2023, 9, 22, 14, 36, 7, 626, DateTimeKind.Local).AddTicks(706),
                            Name = "Física II"
                        });
                });

            modelBuilder.Entity("EduPrime.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 22, 14, 36, 7, 625, DateTimeKind.Local).AddTicks(9756));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AreaEmployee", b =>
                {
                    b.HasOne("EduPrime.Core.Entities.Area", null)
                        .WithMany()
                        .HasForeignKey("AreasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduPrime.Core.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Professor", b =>
                {
                    b.HasOne("EduPrime.Core.Entities.Employee", "Employee")
                        .WithOne("Professor")
                        .HasForeignKey("EduPrime.Core.Entities.Professor", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.ProfessorSubject", b =>
                {
                    b.HasOne("EduPrime.Core.Entities.Professor", "Professor")
                        .WithMany("ProfessorsSubjects")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduPrime.Core.Entities.Subject", "Subject")
                        .WithMany("ProfessorsSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.StudentSubject", b =>
                {
                    b.HasOne("EduPrime.Core.Entities.Student", "Student")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduPrime.Core.Entities.Subject", "Subject")
                        .WithMany("StudentsSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.User", b =>
                {
                    b.HasOne("EduPrime.Core.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Employee", b =>
                {
                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Professor", b =>
                {
                    b.Navigation("ProfessorsSubjects");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Student", b =>
                {
                    b.Navigation("StudentsSubjects");
                });

            modelBuilder.Entity("EduPrime.Core.Entities.Subject", b =>
                {
                    b.Navigation("ProfessorsSubjects");

                    b.Navigation("StudentsSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}