namespace Vestas.Test.Delivery.Application.Service
{
    public interface IAuthService
    {
        string Authenticate(string name, string passCode);
    }

}