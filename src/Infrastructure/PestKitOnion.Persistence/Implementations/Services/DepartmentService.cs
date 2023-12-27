using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Department;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(DepartmentCreateDto departmentDto)
        {
            var department = _mapper.Map<Department>(departmentDto);
            await _repository.AddAsync(department);
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<DepartmentItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Department> departments = await _repository.GetAllWhereAsync(skip: (page - 1) * take, take: take, isTracking: false,ignoreQuery:true).ToListAsync();

            ICollection<DepartmentItemDto> departmentDtos = _mapper.Map<ICollection<DepartmentItemDto>>(departments);


            return departmentDtos;
        }

        public async Task<DepartmentGetDto> GetByIdAsync(int id)
        {
            Department department= await _repository.GetByIdAsync(id,includes:nameof(Department.Employees));
            if (department is null) throw new Exception("Not found");
            var dto = _mapper.Map<DepartmentGetDto>(department);

            return dto;
        }

        public async Task SoftDeleteAsync(int id)
        {
            Department department=await _repository.GetByIdAsync(id);
            if (department is null) throw new Exception("Not Found");
            _repository.SoftDelete(department);
            await _repository.SaveChangesAsync();
        }

        public async Task UpdateAsync(DepartmentUpdateDto departmentDto)
        {
            Department department = await _repository.GetByIdAsync(departmentDto.Id);
            if (department is null) throw new Exception("Not Found");

            department.Name = departmentDto.Name;
            _mapper.Map(departmentDto, department);

            _repository.Update(department);
            await _repository.SaveChangesAsync();
        }
    }
}
