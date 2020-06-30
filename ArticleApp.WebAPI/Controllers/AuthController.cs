using ArticleApp.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ArticleApp.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return Ok(_authManager.GetToken());
        }
    }
}