using Microsoft.AspNetCore.Mvc;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Users;

namespace PestkitOnion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAuthService _service;
        public UsersController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterDto dto)
        {
            await _service.Register(dto);
            return NoContent();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromForm] LoginDto dto)
        {

            return Ok(await _service.Login(dto));
        }
    }
}
