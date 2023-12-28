using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Tokens;
using PestKitOnion.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PestKitOnion.Infrastructure.Implementations
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration _config; 
        public TokenHandler(IConfiguration config)
        {
            _config = config;
        }
        public TokenResponseDto CreateJwt(AppUser user, int hours)
        {
            ICollection<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Surname,user.Surname),
                new Claim(ClaimTypes.GivenName,user.Name),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id)
            };

            SymmetricSecurityKey symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes
                (_config["Jwt:SecurityKey"]));

            SigningCredentials signingCredentials = new(symmetricSecurityKey, SecurityAlgorithms.HmacSha512Signature);

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
               issuer: _config["Jwt:issuer"],
               audience: _config["Jwt:audience"],
               claims: claims,
               notBefore: DateTime.UtcNow,
               expires: DateTime.UtcNow.AddHours(2),
               signingCredentials: signingCredentials
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            TokenResponseDto dto = new TokenResponseDto(handler.WriteToken(jwtSecurityToken),jwtSecurityToken.ValidTo,user.UserName);
            return dto;
        }
    }
}
