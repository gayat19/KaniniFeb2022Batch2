using System.Threading.Tasks;
using UnderstandingJWTApp.Models;

namespace UnderstandingJWTApp.Services
{
    public interface IUserService
    {
        Task<UserDTO> Register(UserDTO user);
        Task<UserDTO> Login(UserDTO user);
    }
}
