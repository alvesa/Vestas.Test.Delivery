using System;
using Microsoft.EntityFrameworkCore;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Infra
{
    public class DeliveryPointContext : DbContext
    {
        public DeliveryPointContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding
            modelBuilder.Entity<DeliveryPoint>().HasData(
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'A', Destination = 'C', Time = 1, Cost = 20},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'C', Destination = 'B', Time = 1, Cost = 12},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'A', Destination = 'E', Time = 30, Cost = 5},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'A', Destination = 'H', Time = 10, Cost = 1},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'H', Destination = 'E', Time = 30, Cost = 1},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'E', Destination = 'D', Time = 3, Cost = 5},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'D', Destination = 'F', Time = 4, Cost = 50},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'F', Destination = 'I', Time = 45, Cost = 50},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'I', Destination = 'B', Time = 65, Cost = 5},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'F', Destination = 'G', Time = 40, Cost = 50},
                new DeliveryPoint { Id = Guid.NewGuid(), Origin = 'G', Destination = 'B', Time = 64, Cost = 73}
            );

            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Name = "Andre", PassCode = "123456", Role = "Admin"},
                new User { Id = Guid.NewGuid(), Name = "Customer", PassCode = "123456", Role = "Customer"}
            );
        }

        public DbSet<DeliveryPoint> DeliveryPoint { get; set; }
        public DbSet<User> User { get; set; }
    }
}