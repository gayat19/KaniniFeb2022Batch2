using UnderstandingJWTApp.Models;

namespace UnderstandingJWTApp.Services
{
    public interface ITokenService
    {
        public string GenerateToken(UserDTO user);
    }
}
