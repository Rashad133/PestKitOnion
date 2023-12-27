using PestKitOnion.Application.DTOs.Blog;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IBlogService
    {
        Task<ICollection<BlogItemDto>> GetAllAsync(int page, int take);
        Task<BlogGetDto> GetByIdAsync(int id);
        Task CreateAsync(BlogCreateDto blogDto);
        Task UpdateAsync(int id,BlogUpdateDto blogDto);
        Task SoftDeleteAsync(int id);
    }
}
