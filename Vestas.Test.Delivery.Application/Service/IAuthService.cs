using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Service
{
    public interface IAuthService
    {
        User Authenticate(string name, string passCode);
        string GenerateToken(Model.User user);
    }

}