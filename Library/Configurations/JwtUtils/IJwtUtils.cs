using Library.Models.Employee;

namespace Library.Configurations.JwtUtils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(string username, LoginInfoDTO loginInfo);
    }
}
