using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpPost("Register")]
        public async Task Register()
        {
            
        }
    }
}