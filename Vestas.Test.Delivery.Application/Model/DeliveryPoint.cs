namespace Vestas.Test.Delivery.Application.Model
{
    public class DeliveryPoint
    {
        public char Origin { get; set; }
        public char Destination { get; set; }
        public int Time { get; set; }
        public int Container { get; set; }
        public int Cost { get; set; }
        public bool Visited { get; set; }
    }
}