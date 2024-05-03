using Microsoft.AspNetCore.Mvc;
using AuthServer.Core.Service;
using System.Threading.Tasks;

namespace AuthServer.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IAuthService _authService;

        public AuthController(IUserServices userServices, IAuthService authService)
        {
            _userServices = userServices;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(string username, string password)
        {
            if (await _userServices.RegisterAsync(username, password))
                return Ok();

            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(string username, string password)
        {
            var token = await _userServices.AuthenticateAsync(username, password);
            if (token != null)
                return Ok(new { Token = token });

            return Unauthorized();
        }
    }
}


