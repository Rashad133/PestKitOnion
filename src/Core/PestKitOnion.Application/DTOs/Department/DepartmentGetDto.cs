using PestKitOnion.Application.DTOs.Employee;

namespace PestKitOnion.Application.DTOs.Department;

public record DepartmentGetDto(string Name, ICollection<IncludeEmployeeDto> Employees);

