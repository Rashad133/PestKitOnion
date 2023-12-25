using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Application.DTOs.Department;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IDepartmentService
    {
        Task<ICollection<DepartmentItemDto>> GetAllAsync(int page, int take);
        Task CreateAsync(DepartmentCreateDto departmentDto);
        Task UpdateAsync(DepartmentUpdateDto departmentDto);
        Task SoftDeleteAsync(int id);
    }
}
