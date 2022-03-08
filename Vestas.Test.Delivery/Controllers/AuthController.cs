using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vestas.Test.Delivery.Application.Service;
using Vestas.Test.Delivery.Infra;
using Vestas.Test.Delivery.ViewModel;

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
        public IActionResult Auth([FromBody]AuthViewModel user)
        {
            var userValidated = _service.Authenticate(user.Name, user.PassCode);

            if(userValidated == null)
                return NotFound();

            var token = _service.GenerateToken(userValidated);

            return Ok(new 
                { 
                    Role = userValidated.Role,
                    Name = userValidated.Name, 
                    token 
                }
            );
        }

    }
}