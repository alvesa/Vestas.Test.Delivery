using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _service;

        public AuthService(IUserService service)
        {
            _service = service;
        }

        public User Authenticate(string name, string passCode)
        {
            return _service.GetUserByCredentials(name, passCode);
        }
    }
}