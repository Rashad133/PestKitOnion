using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _repository;
        private readonly IMapper _mapper;
        public PositionService(IPositionRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(PositionCreateDto positionDto)
        {
            var position = _mapper.Map<Position>(positionDto);
            await _repository.AddAsync(position);
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<PositionItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Position> positions=await _repository.GetAllAsync(skip:(page-1)*take,take:take,isTracking:false).ToListAsync();
            ICollection<PositionItemDto> positionDtos = _mapper.Map<ICollection<PositionItemDto>>(positions);

            return positionDtos;
        }

        public async Task SoftDeleteAsync(int id)
        {
            Position position= await _repository.GetByIdAsync(id);
            if (id <= 0) throw new Exception("Not Found");
            _repository.SoftDelete(position);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(PositionUpdateDto positionDto)
        {
            Position position = await _repository.GetByIdAsync(positionDto.Id);
            if (position is null) throw new Exception("Not Found");

            position.Name= positionDto.Name;
            _mapper.Map(positionDto,position);

            _repository.Update(position);
            await _repository.SaveChangesAsync();
        }
    }
}
