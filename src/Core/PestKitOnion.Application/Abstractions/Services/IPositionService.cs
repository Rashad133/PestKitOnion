using PestKitOnion.Application.DTOs.Position;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IPositionService
    {
        Task<ICollection<PositionItemDto>> GetAllAsync(int page,int take);
        Task<PositionGetDto> GetByIdAsync(int id);
        Task CreateAsync(PositionCreateDto positionDto);
        Task UpdateAsync(PositionUpdateDto positionDto);
        Task SoftDeleteAsync(int id);
    }
}
