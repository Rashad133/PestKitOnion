
using PestKitOnion.Application.DTOs.Employee;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeItemDto>> GetAllWhereAsync(int page, int take);
        Task<EmployeeGetDto> GetByIdAsync(int id);
        Task CreateAsync(EmployeeCreateDto employeeDto);
        Task UpdateAsync(int id, EmployeeUpdateDto employeeDto);
        Task SoftDeleteAsync(int id);
    }
}
