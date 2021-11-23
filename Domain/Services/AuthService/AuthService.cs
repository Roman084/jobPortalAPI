using System.Threading.Tasks;
using AutoMapper;
using jobPortalAPI.Data;
using jobPortalAPI.Data.Entities;
using jobPortalAPI.Domain.Dtos.UserDto;
using Microsoft.AspNetCore.Identity;

namespace jobPortalAPI.Domain.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly TokenService _tokenService;
        private readonly RoleManager<User> _roleManager;
        private readonly DataDbContext _dbContext;
        private readonly IMapper _mapper;
        public AuthService(
            UserManager<User> userManager, 
            SignInManager<User> signInManager, 
            TokenService tokenService, 
            RoleManager<User> roleManager, 
            DataDbContext dbContext, 
            IMapper mapper
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _roleManager = roleManager;
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task RegisterUser(RegisterUserDto registerUserDto)
        {
            var user = await _userManager.FindByEmailAsync(registerUserDto.Email);
        }
    }
}