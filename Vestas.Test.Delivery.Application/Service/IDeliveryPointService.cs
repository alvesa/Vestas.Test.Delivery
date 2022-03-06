using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Service
{
    public interface IDeliveryPointService
    {
        int GetShortDistance(char pointA, char pointB);
    }
}