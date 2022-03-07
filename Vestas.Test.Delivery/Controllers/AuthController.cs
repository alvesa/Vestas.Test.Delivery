using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Auth(string name, string passCode)
        {
            return null;
        }

    }
}