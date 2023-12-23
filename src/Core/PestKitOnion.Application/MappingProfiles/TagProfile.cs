using AutoMapper;
using PestKitOnion.Application.DTOs.Department;
using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagItemeDto>().ReverseMap();
            CreateMap<Tag, TagUpdateDto>().ReverseMap();
            CreateMap<Tag, TagCreateDto>().ReverseMap();
        }
    }
}
