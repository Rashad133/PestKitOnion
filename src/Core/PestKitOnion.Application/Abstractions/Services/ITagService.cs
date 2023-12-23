
using PestKitOnion.Application.DTOs.Tag;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface ITagService
    {
        Task<ICollection<TagItemeDto>> GetAllAsync(int page, int take);
        Task CreateAsync(TagCreateDto tagDto);
        Task UpdateAsync(TagUpdateDto tagDto);

    }
}
