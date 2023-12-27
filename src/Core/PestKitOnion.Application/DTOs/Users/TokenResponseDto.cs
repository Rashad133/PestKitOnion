namespace PestKitOnion.Application.DTOs.Users;

public record TokenResponseDto(string Token,DateTime Expires,string UserName);
