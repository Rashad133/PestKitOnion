using AutoMapper;
using PestKitOnion.Application.DTOs.Blog;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class BlogProfile:Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, BlogCreateDto>().ReverseMap();
            CreateMap<Blog, BlogItemDto>().ReverseMap();
            CreateMap<Blog, BlogGetDto>().ReverseMap();
            CreateMap<Blog, BlogUpdateDto>().ReverseMap();
            CreateMap<Blog, IncludeBlogDto>().ReverseMap();
        }
    }
}
