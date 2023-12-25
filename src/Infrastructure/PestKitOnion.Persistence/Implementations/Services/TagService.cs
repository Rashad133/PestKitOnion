using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;
        public TagService(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(TagCreateDto tagDto)
        {
            var tag = _mapper.Map<Tag>(tagDto);
            await _repository.AddAsync(tag);
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<TagItemeDto>> GetAllAsync(int page, int take)
        {
            ICollection<Tag> tags = await _repository.GetAllAsync(skip: (page - 1) * take, take: take, isTracking: false).ToListAsync();

            ICollection<TagItemeDto> tagDtos = _mapper.Map<ICollection<TagItemeDto>>(tags);


            return tagDtos;
        }

        public  async Task SoftDeleteAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);
            if (id <= 0) throw new Exception("Not Found");
            _repository.SoftDelete(tag);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(TagUpdateDto tagDto)
        {
            Tag tag = await _repository.GetByIdAsync(tagDto.Id);
            if (tag is null) throw new Exception("Not Found");

            tag.Name = tagDto.Name;
            _mapper.Map(tagDto, tag);

            _repository.Update(tag);
            await _repository.SaveChangesAsync();
        }
    }
}
