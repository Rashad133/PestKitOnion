using PestKitOnion.Application.DTOs.Employee;

namespace PestKitOnion.Application.DTOs.Position
{
    public record PositionGetDto(string Name, ICollection<IncludeEmployeeDto> Employees);
}
