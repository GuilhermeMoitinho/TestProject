using Microsoft.IdentityModel.Tokens;
using ProjetoJWT.WebAPI.Application.interfaces;
using ProjetoJWT.WebAPI.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProjetoJWT.WebAPI.Application.Auth
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GerarToken(User user)
        {
            var issuerValue = _configuration["Jwt:Issuer"];
            var audienceValue = _configuration["Jwt:Audience"];
            var key = _configuration["Jwt:Key"];

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var signingCredentialsValue = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                    issuer: issuerValue,
                    audience: audienceValue,
                claims: new[]
                {
                    new Claim(type: ClaimTypes.Email, user.Email),
                    new Claim(type: ClaimTypes.Role, user.Role),
                },
                    expires: DateTime.UtcNow.AddHours(1),
                    signingCredentials: signingCredentialsValue);

            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            return token;
        }
    }
}
