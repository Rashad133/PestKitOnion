using PestKitOnion.Application.DTOs.Author;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IAuthorService
    {
        Task<ICollection<AuthorItemDto>> GetAllAsync(int page, int take);
        Task<AuthorGetDto> GetByIdAsync(int id);
        Task CreateAsync(AuthorCreateDto authorDto);
        Task UpdateAsync(AuthorUpdateDto authorDto);
        Task SoftDeleteAsync(int id);
    }
}
