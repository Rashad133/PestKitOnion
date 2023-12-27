
using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Application.DTOs.Tag;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface ITagService
    {
        Task<ICollection<TagItemeDto>> GetAllAsync(int page, int take);
        Task<TagGetDto> GetByIdAsync(int id);
        Task CreateAsync(TagCreateDto tagDto);
        Task UpdateAsync(TagUpdateDto tagDto);
        Task SoftDeleteAsync(int id);

    }
}
