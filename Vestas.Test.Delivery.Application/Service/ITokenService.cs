namespace Vestas.Test.Delivery.Application.Service
{
    public interface ITokenService
    {
        string GenerateToken(Model.User user);
    }
}