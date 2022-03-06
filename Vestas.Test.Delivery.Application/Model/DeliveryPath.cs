using System.Collections.Generic;

namespace Vestas.Test.Delivery.Application.Model
{
    public class DeliveryPath
    {
        public DeliveryPath(char origin, IDictionary<char, int> point)
        {
            Origin = origin;
            Point = point;
        }

        public char Origin { get; set; }
        public IDictionary<char, int> Point { get; set; }
    }
}