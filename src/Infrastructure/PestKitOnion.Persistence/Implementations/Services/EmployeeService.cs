using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Employee;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IPositionRepository _positionRepository;
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IDepartmentRepository departmentRepository, IMapper mapper, IPositionRepository positionRepository)
        {
            _departmentRepository = departmentRepository;
            _positionRepository = positionRepository;
            _mapper = mapper;
            _repository = repository;
        }

        public async Task CreateAsync(EmployeeCreateDto employeeDto)
        {
            var employee = _mapper.Map<Employee>(employeeDto);
            await _repository.AddAsync(employee);
            await _repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeItemDto>> GetAllWhereAsync(int page, int take)
        {
            ICollection<Employee> employees = await _repository.GetAllWhereAsync(skip: (page - 1) * take, take: take, isTracking: false).ToListAsync();
            ICollection<EmployeeItemDto> employeeDtos = _mapper.Map<ICollection<EmployeeItemDto>>(employees);

            return employeeDtos;
        }

        public async Task<EmployeeGetDto> GetByIdAsync(int id)
        {
            Employee employee = await _repository.GetByIdAsync(id, includes: new string[] { $"{nameof(Employee.Department)}", $"{nameof(Employee.Position)}"  });
            EmployeeGetDto dto = _mapper.Map<EmployeeGetDto>(employee);
            return dto;
        }

        public async Task SoftDeleteAsync(int id)
        {
            Employee employee = await _repository.GetByIdAsync(id);
            if (employee is null) throw new Exception("Not Found");
            _repository.SoftDelete(employee);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id,EmployeeUpdateDto employeeDto)
        {
            Employee employee = await _repository.GetByIdAsync(id);
            if (employee is null) throw new Exception("Not Found");

            employee.Name = employeeDto.Name;
            _mapper.Map(employeeDto, employee);

            _repository.Update(employee);
            await _repository.SaveChangesAsync();
        }

        
    }
}
