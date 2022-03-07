using System.Collections.Generic;
using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Service
{
    public interface IDeliveryPointService
    {
        int GetShortDistance(char pointA, char pointB);
        IEnumerable<DeliveryPoint> GetPoints();
        DeliveryPoint GetPointsByNode(char node);
        Task UpdatePoint(DeliveryPoint point);
        Task CreatePoint(DeliveryPoint point);
        Task DeletePoint(char pointA, char pointB);
    }
}