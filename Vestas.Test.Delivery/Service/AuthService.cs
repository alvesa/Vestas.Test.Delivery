using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _service;
        private readonly ITokenService _tokenService;

        public AuthService(IUserService service, ITokenService tokenService = null)
        {
            _service = service;
            _tokenService = tokenService;
        }

        public User Authenticate(string name, string passCode)
        {
            return _service.GetUserByCredentials(name, passCode);
        }

        public string GenerateToken(User user)
        {
            return _tokenService.GenerateToken(user);
        }
    }
}