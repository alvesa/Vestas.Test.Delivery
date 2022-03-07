using Microsoft.EntityFrameworkCore;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Infra
{
    public class DeliveryPointContext : DbContext
    {
        public DeliveryPointContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DeliveryPoint> DeliveryPoint { get; set; }
        public DbSet<User> User { get; set; }
    }
}