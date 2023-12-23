using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Position;

namespace PestkitOnion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionService _service;
        public PositionsController(IPositionService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int page=1,int take = 3)
        {
            return Ok(await _service.GetAllAsync(page,take));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PositionCreateDto positionDto)
        {
            await _service.CreateAsync(positionDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] PositionUpdateDto positionDto)
        {
            if (positionDto.Id <= 0) return StatusCode(StatusCodes.Status400BadRequest);
            await _service.UpdateAsync(positionDto);
            return NoContent();

        }
    }
}
