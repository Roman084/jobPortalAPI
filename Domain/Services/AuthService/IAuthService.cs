using System.Threading.Tasks;
using jobPortalAPI.Domain.Dtos.UserDto;

namespace jobPortalAPI.Domain.Services.AuthService
{
    public interface IAuthService
    {
        Task RegisterUser(RegisterUserDto registerUserDto);
    }
}