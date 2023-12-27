using AutoMapper;
using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorItemDto>().ReverseMap();
            CreateMap<Author, AuthorCreateDto>().ReverseMap();
            CreateMap<Author, AuthorUpdateDto>().ReverseMap();
            CreateMap<Author, IncludeAuthorDto>().ReverseMap();

            CreateMap<Author, AuthorGetDto>();

        }
    }
}
