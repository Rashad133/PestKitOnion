using AutoMapper;
using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class PositionProfile:Profile
    {
        public PositionProfile()
        {
            CreateMap<Position,PositionItemDto>().ReverseMap();
            CreateMap<Position,PositionUpdateDto>().ReverseMap();
            CreateMap<Position,PositionCreateDto>().ReverseMap();
        }
    }
}
