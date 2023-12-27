using PestKitOnion.Application.DTOs.Department;
using PestKitOnion.Application.DTOs.Position;

namespace PestKitOnion.Application.DTOs.Employee
{
    public record EmployeeGetDto(int Id, string Name,string Surname, int DepartmentId, IncludeDepartmentDto Department, int PositionId, IncludePositionDto Position);
}
