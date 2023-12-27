using AutoMapper;
using PestKitOnion.Application.DTOs.Users;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    internal class AppUserProfile:Profile
    {
        public AppUserProfile()
        {
            CreateMap<RegisterDto, AppUser>();
        }
    }
}
