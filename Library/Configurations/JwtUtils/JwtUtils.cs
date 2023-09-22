using Library.Models.Employee;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Library.Configurations.JwtUtils
{
    public class JwtUtils : IJwtUtils
    {
        private readonly AppSettings _appSettings;

        public JwtUtils(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

            if (string.IsNullOrEmpty(_appSettings.Secret))
                throw new Exception("JWT secret not configured");
            if (string.IsNullOrEmpty(_appSettings.Issuer))
                throw new Exception("JWT Issuer not configured");
            if (string.IsNullOrEmpty(_appSettings.Audience))
                throw new Exception("JWT Audience not configured");
        }

        public string GenerateJwtToken(string username, LoginInfoDTO loginInfo)
        {
            var claims = new[]
  {
            new Claim(ClaimTypes.NameIdentifier, username),
            new Claim(ClaimTypes.GivenName, loginInfo.First_Name),
            new Claim(ClaimTypes.Surname, loginInfo.Last_Name),
            new Claim(ClaimTypes.Role, loginInfo.Position)
        };

            var token = new JwtSecurityToken
                (
                    issuer: _appSettings.Issuer,
                    audience: _appSettings.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.AddDays(2),
                    notBefore: DateTime.UtcNow,
                    signingCredentials: new SigningCredentials
                    (
                       key: new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.Secret)),
                       algorithm: SecurityAlgorithms.HmacSha256
                    )
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
