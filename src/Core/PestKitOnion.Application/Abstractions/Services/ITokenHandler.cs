using PestKitOnion.Application.DTOs.Tokens;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface ITokenHandler
    {
        TokenResponseDto CreateJwt(AppUser user,int hours);
    }
}
