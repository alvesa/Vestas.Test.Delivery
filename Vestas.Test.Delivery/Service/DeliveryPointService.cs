using System.Collections.Generic;
using System.Linq;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Service
{
    public class DeliveryPointService : IDeliveryPointService
    {
        private IDictionary<char, IGrouping<char, DeliveryPoint>> _originGroup;
        public DeliveryPointService()
        {
            MockService();
            _originGroup = points.GroupBy(x => x.Origin)
            .ToDictionary(x => x.Key, x => x);
        }
        private IList<DeliveryPoint> points;
        public IList<int> shortestValue;

        public int GetShortDistance(char pointA, char pointB)
        {
            shortestValue = new List<int>();
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

        public void MockService()
        {
            points = new List<DeliveryPoint> {
                new DeliveryPoint {
                    Origin = 'A',
                    Destination = 'C',
                    Time = 1,
                    Cost = 20,
                },
                new DeliveryPoint {
                    Origin = 'A',
                    Destination = 'E',
                    Time = 30,
                    Cost = 5,
                },
                new DeliveryPoint {
                    Origin = 'A',
                    Destination = 'H',
                    Time = 10,
                    Cost = 1,
                },
                new DeliveryPoint {
                    Origin = 'C',
                    Destination = 'B',
                    Time = 1,
                    Cost = 12,
                },
                new DeliveryPoint {
                    Origin = 'E',
                    Destination = 'D',
                    Time = 3,
                    Cost = 5,
                },
                new DeliveryPoint {
                    Origin = 'H',
                    Destination = 'E',
                    Time = 30,
                    Cost = 1,
                },
                new DeliveryPoint {
                    Origin = 'D',
                    Destination = 'F',
                    Time = 4,
                    Cost = 50,
                },
                new DeliveryPoint {
                    Origin = 'F',
                    Destination = 'I',
                    Time = 45,
                    Cost = 50,
                },
                new DeliveryPoint {
                    Origin = 'F',
                    Destination = 'G',
                    Time = 40,
                    Cost = 50,
                },
                new DeliveryPoint {
                    Origin = 'I',
                    Destination = 'B',
                    Time = 65,
                    Cost = 5,
                },
                new DeliveryPoint {
                    Origin = 'G',
                    Destination = 'B',
                    Time = 64,
                    Cost = 73,
                },
                /*new DeliveryPoint {
                    Origin = 'B',
                    
                    
                    
                },*/
            };
        }
    
    }
}