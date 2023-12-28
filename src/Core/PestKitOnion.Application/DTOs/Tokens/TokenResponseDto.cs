namespace PestKitOnion.Application.DTOs.Tokens
{
    public record TokenResponseDto(string Token, DateTime ExpireTime, string UserName);
}
