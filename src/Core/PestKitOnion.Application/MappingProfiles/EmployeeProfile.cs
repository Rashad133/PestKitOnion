using AutoMapper;
using PestKitOnion.Application.DTOs.Employee;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeItemDto>().ReverseMap();
            CreateMap<Employee, EmployeeGetDto>().ReverseMap();
            CreateMap<EmployeeCreateDto, Employee>().ReverseMap();
            CreateMap<Employee,EmployeeUpdateDto>().ReverseMap();
            CreateMap<Employee, IncludeEmployeeDto>().ReverseMap();
        }
    }
}
