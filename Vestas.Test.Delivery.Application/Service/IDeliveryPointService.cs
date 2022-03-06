using System.Collections.Generic;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Service
{
    public interface IDeliveryPointService
    {
        int GetShortDistance(char pointA, char pointB);
        IEnumerable<DeliveryPoint> GetPoints();
        IEnumerable<DeliveryPoint> GetPointsByNode(char node);
        void UpdatePoint(DeliveryPoint point);
        void CreatePoint(DeliveryPoint point);
        void DeletePoint(char pointA, char pointB);
    }
}