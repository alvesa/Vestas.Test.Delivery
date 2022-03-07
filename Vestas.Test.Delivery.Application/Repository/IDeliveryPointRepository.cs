using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Repository
{
    public interface IDeliveryPointRepository
    {
        Task CreatePoint(DeliveryPoint deliveryPoint);
        Task UpdatePoint(DeliveryPoint deliveryPoint);
        Task DeletePoint(char pointA, char pointB);
        IEnumerable<DeliveryPoint> GetPoints();
        DeliveryPoint GetPointsByNode(Expression<Func<DeliveryPoint, bool>> predicate);
    }
}