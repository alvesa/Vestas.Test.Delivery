using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Repository;
using Vestas.Test.Delivery.Application.Service;
using Vestas.Test.Delivery.Infra.Repository;

namespace Vestas.Test.Delivery.Service
{
    public class DeliveryPointService : IDeliveryPointService
    {
        private IDictionary<char, IGrouping<char, DeliveryPoint>> _originGroup;
        public IList<int> shortestValue;
        private readonly IDeliveryPointRepository _repository;

        public DeliveryPointService(IDeliveryPointRepository repository)
        {
            _repository = repository;
        }

        public int GetShortDistance(char pointA, char pointB)
        {
            shortestValue = new List<int>();
            _originGroup = _repository.GetPoints().GroupBy(x => x.Origin)
                .ToDictionary(x => x.Key, x => x);

            var res = GetShortPath(pointA, pointB, 0);

            return shortestValue.Where(x => x > 0).Min();
        }     

        public int GetShortPath(char pointA, char pointB, int value)
        {
            var result = value;

            if(!_originGroup.ContainsKey(pointA))
            {
                result = int.MaxValue;
                shortestValue.Add(result);
                return result;
            }

            var originPoints = _originGroup[pointA].OrderBy(x => x.Time);

            foreach (var item in originPoints)
            {
                
                item.Container = value + item.Time;

                if(item.Destination == pointB)
                {
                    result = item.Container;
                    shortestValue.Add(result);
                    break;
                }

                result = GetShortPath(item.Destination, pointB, item.Container);
            }

            return result;
        }

        public IEnumerable<DeliveryPoint> GetPoints()
        {
            return _repository.GetPoints();
        }

        public DeliveryPoint GetPointsByNode(char node)
        {
            return _repository.GetPointsByNode(x => x.Origin == node);
        }

        public async Task UpdatePoint(DeliveryPoint point)
        {
            await _repository.UpdatePoint(point);
        }

        public async Task CreatePoint(DeliveryPoint point)
        {
            await _repository.CreatePoint(point);
        }

        public async Task DeletePoint(char pointA, char pointB)
        {
            await _repository.DeletePoint(pointA, pointB);
        }
    }
}