using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Author;

namespace PestkitOnion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _service;
        public AuthorsController(IAuthorService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get(int page = 1, int take = 3)
        {
            return Ok(await _service.GetAllAsync(page, take));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] AuthorCreateDto categoryDto)
        {
            await _service.CreateAsync(categoryDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut()]
        public async Task<IActionResult> Update([FromForm] AuthorUpdateDto categoryDto)
        {
            if (categoryDto.Id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.UpdateAsync(categoryDto);
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
