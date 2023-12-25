using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Application.DTOs.Department;

namespace PestkitOnion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _service;
        public DepartmentsController(IDepartmentService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int take = 3)
        {
            return Ok(await _service.GetAllAsync(page, take));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] DepartmentCreateDto departmentDto)
        {
            await _service.CreateAsync(departmentDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] DepartmentUpdateDto departmentDto)
        {
            if (departmentDto.Id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.UpdateAsync(departmentDto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.SoftDeleteAsync(id);
            return NoContent();
        }
    }
}
