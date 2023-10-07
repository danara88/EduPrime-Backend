﻿using AutoMapper;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Area
            CreateMap<Area, AreaDTO>();
            CreateMap<CreateAreaDTO, Area>();
            CreateMap<UpdateAreaDTO, Area>();
            CreateMap<Area, AreaWithEmployeesDTO>();
            CreateMap<Employee, EmployeeForAreaDTO>();
            #endregion

            #region Employee
            CreateMap<Employee, EmployeeDTO>();
            CreateMap<CreateEmployeeDTO, Employee>()
                .ForMember(ent => ent.Areas, dto => dto.MapFrom(prop => prop.Areas.Select(id => new Area() { Id = id })));
            CreateMap<UpdateEmployeeDTO, Employee>();
            #endregion

            #region Professor
            CreateMap<Professor, ProfessorDTO>();
            CreateMap<CreateProfessorDTO, Professor>();
            CreateMap<UpdateProfessorDTO, Professor>();
            #endregion

            #region Subject
            CreateMap<Subject, SubjectDTO>()
                .ForMember(dto => dto.Professors, ent => ent.MapFrom(prop => prop.ProfessorsSubjects.Select(ps => ps.Professor)));
            CreateMap<CreateSubjectDTO, Subject>();
            CreateMap<UpdateSubjectDTO, Subject>();
            #endregion

            #region Student
            CreateMap<Student, StudentDTO>()
                .ForMember(dto => dto.Assignments, ent => ent.MapFrom(prop => prop.StudentsSubjects));
            CreateMap<UpdateStudentDTO, Student>();
            CreateMap<CreateStudentDTO, Student>();
            #endregion

            #region StudentSubject
            CreateMap<StudentSubject, StudentSubjectDTO>();
            #endregion

            #region User
            CreateMap<RegisterUserDTO, User>();
            CreateMap<User, UserDTO>();
            CreateMap<UpdateUserDTO, User>();
            #endregion

            #region Role
            CreateMap<Role, RoleDTO>();
            CreateMap<Role, RoleWithUsersDTO>();
            CreateMap<CreateRoleDTO, Role>();
            #endregion
        }
    }
}
