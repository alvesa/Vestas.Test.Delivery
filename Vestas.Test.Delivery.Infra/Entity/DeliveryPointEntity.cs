using System;
using System.ComponentModel.DataAnnotations;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Infra.Entity
{
    public class DeliveryPointEntity : DeliveryPoint
    {
        [Key]
        public Guid Id { get; set; }
    }
}