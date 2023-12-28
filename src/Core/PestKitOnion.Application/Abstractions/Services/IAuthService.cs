using PestKitOnion.Application.DTOs.Tokens;
using PestKitOnion.Application.DTOs.Users;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IAuthService
    {
        Task Register(RegisterDto dto);
        Task<TokenResponseDto> Login(LoginDto dto);
    }
}
