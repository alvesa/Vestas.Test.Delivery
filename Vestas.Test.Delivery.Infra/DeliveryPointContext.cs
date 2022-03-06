using Microsoft.EntityFrameworkCore;
using Vestas.Test.Delivery.Infra.Entity;

namespace Vestas.Test.Delivery.Infra
{
    public class DeliveryPointContext : DbContext
    {
        public DeliveryPointContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DeliveryPointEntity> DeliveryPoint { get; set; }
    }
}