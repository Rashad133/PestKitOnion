using AutoMapper;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Blog;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repository;
        private readonly IMapper _mapper;
        public BlogService(IBlogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task CreateAsync(BlogCreateDto blogDto)
        {
            await _repository.AddAsync(_mapper.Map<Blog>(blogDto));
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<BlogItemDto>> GetAllAsync(int page, int take)
        {
            List<Blog> blogs = await _repository.GetAllWhereAsync(skip: (page - 1) * take, take: take, isTracking:false, ignoreQuery: false, includes: new string[] { "Author" }).ToListAsync();

            List<BlogItemDto> blogDtos = _mapper.Map<List<BlogItemDto>>(blogs);

            return blogDtos;
        }

        public async Task<BlogGetDto> GetByIdAsync(int id)
        {
            Blog blog = await _repository.GetByIdAsync(id: id, isDeleted: true, includes: new string[] { "Author" });

            if (blog is null) throw new Exception("Not found");
            var dto = _mapper.Map<BlogGetDto>(blog);

            return dto;
        }

        public async Task SoftDeleteAsync(int id)
        {
            Blog blog = await _repository.GetByIdAsync(id);
            if (blog is null) throw new Exception("Not found");
            _repository.SoftDelete(blog);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id,BlogUpdateDto blogDto)
        {
            Blog blog = await _repository.GetByIdAsync(id);

            if (blog is null) throw new Exception("Not found");

            blog = _mapper.Map(blogDto, blog);

            _repository.Update(blog);
            await _repository.SaveChangesAsync();
        }

        
    }
}
