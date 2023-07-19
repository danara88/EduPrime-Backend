using AutoMapper;
using EduPrime.Core.DTOs.Area;
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
            CreateMap<Area, AreaWithEmployeesDTO>()
                .ForMember(dto => dto.Employees, ent => ent.MapFrom(prop => prop.AreasEmployees.Select(ae => ae.Employee)));
            CreateMap<Employee, EmployeeForAreaDTO>();
            #endregion
        }
    }
}
