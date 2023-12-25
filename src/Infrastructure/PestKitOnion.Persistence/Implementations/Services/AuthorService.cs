using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class AuthorService : IAuthorService
    {
        
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;
        public AuthorService(IAuthorRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ICollection<AuthorItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Author> authors = await _repository.GetAllAsync(skip: (page - 1) * take, take: take, isTracking: false).ToListAsync();

            ICollection<AuthorItemDto> authorDtos = _mapper.Map<ICollection<AuthorItemDto>>(authors);


            return authorDtos;
        }
        public async Task CreateAsync(AuthorCreateDto authorDto)
        {
            var author = _mapper.Map<Author>(authorDto);
            await _repository.AddAsync(author);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(AuthorUpdateDto authorDto)
        {
            Author author = await _repository.GetByIdAsync(authorDto.Id);
            if (author is null) throw new Exception("Not Found");

            author.Name = authorDto.Name;
            _mapper.Map(authorDto, author);

            _repository.Update(author);
            await _repository.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(int id)
        {
            Author author= await _repository.GetByIdAsync(id);
            if (author is null) throw new Exception("Not Found");
            _repository.SoftDelete(author);
            await _repository.SaveChangesAsync();
        }
    }
}
