using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vestas.Test.Delivery.Application.Model
{
    public class DeliveryPoint
    {
        [Key]
        public Guid Id { get; set; }
        public char Origin { get; set; }
        public char Destination { get; set; }
        public int Time { get; set; }
        [NotMapped]
        public int Container { get; set; }
        public int Cost { get; set; }
    }
}