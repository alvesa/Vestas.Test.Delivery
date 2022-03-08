﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vestas.Test.Delivery.Infra;

namespace Vestas.Test.Delivery.Infra.Migrations
{
    [DbContext(typeof(DeliveryPointContext))]
    partial class DeliveryPointContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("Vestas.Test.Delivery.Application.Model.DeliveryPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeliveryPoint");

                    b.HasData(
                        new
                        {
                            Id = new Guid("91388692-2f97-401d-a249-46612e35ace0"),
                            Cost = 20,
                            Destination = "C",
                            Origin = "A",
                            Time = 1
                        },
                        new
                        {
                            Id = new Guid("3d4e5df3-b1b4-4616-b6f6-768e0440317c"),
                            Cost = 12,
                            Destination = "B",
                            Origin = "C",
                            Time = 1
                        },
                        new
                        {
                            Id = new Guid("f785a817-fa22-47f5-95fd-30ce1843f51f"),
                            Cost = 5,
                            Destination = "E",
                            Origin = "A",
                            Time = 30
                        },
                        new
                        {
                            Id = new Guid("0f4cc44e-3759-481d-8450-159ea34a909e"),
                            Cost = 1,
                            Destination = "H",
                            Origin = "A",
                            Time = 10
                        },
                        new
                        {
                            Id = new Guid("7069d88d-3e33-4efb-9a5f-346030bab253"),
                            Cost = 1,
                            Destination = "E",
                            Origin = "H",
                            Time = 30
                        },
                        new
                        {
                            Id = new Guid("92667a4d-102e-4019-bc41-a620763d5a08"),
                            Cost = 5,
                            Destination = "D",
                            Origin = "E",
                            Time = 3
                        },
                        new
                        {
                            Id = new Guid("20545c78-7d42-408c-94b2-7b2fa025a05e"),
                            Cost = 50,
                            Destination = "F",
                            Origin = "D",
                            Time = 4
                        },
                        new
                        {
                            Id = new Guid("6c0b3e87-ddf0-4d93-a211-7c677ab99f59"),
                            Cost = 50,
                            Destination = "I",
                            Origin = "F",
                            Time = 45
                        },
                        new
                        {
                            Id = new Guid("d6440eaa-c781-4901-9519-1760a9ed0d44"),
                            Cost = 5,
                            Destination = "B",
                            Origin = "I",
                            Time = 65
                        },
                        new
                        {
                            Id = new Guid("5b98843b-e9df-40ab-847d-6e87144276e2"),
                            Cost = 50,
                            Destination = "G",
                            Origin = "F",
                            Time = 40
                        },
                        new
                        {
                            Id = new Guid("70ef6c26-8305-422d-93dd-1ee9564c013d"),
                            Cost = 73,
                            Destination = "B",
                            Origin = "G",
                            Time = 64
                        });
                });

            modelBuilder.Entity("Vestas.Test.Delivery.Application.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PassCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bacb6589-5eb4-4b85-b80f-94685d374e2d"),
                            Name = "Andre",
                            PassCode = "123456",
                            Role = "Admin"
                        },
                        new
                        {
                            Id = new Guid("818aeb9f-7946-4db2-9023-3a5899b70d1e"),
                            Name = "Customer",
                            PassCode = "123456",
                            Role = "Customer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
