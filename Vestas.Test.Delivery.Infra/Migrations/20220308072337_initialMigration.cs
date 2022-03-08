using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vestas.Test.Delivery.Infra.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DeliveryPoint",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Origin = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Destination = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPoint", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PassCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DeliveryPoint",
                columns: new[] { "Id", "Cost", "Destination", "Origin", "Time" },
                values: new object[,]
                {
                    { new Guid("91388692-2f97-401d-a249-46612e35ace0"), 20, "C", "A", 1 },
                    { new Guid("3d4e5df3-b1b4-4616-b6f6-768e0440317c"), 12, "B", "C", 1 },
                    { new Guid("f785a817-fa22-47f5-95fd-30ce1843f51f"), 5, "E", "A", 30 },
                    { new Guid("0f4cc44e-3759-481d-8450-159ea34a909e"), 1, "H", "A", 10 },
                    { new Guid("7069d88d-3e33-4efb-9a5f-346030bab253"), 1, "E", "H", 30 },
                    { new Guid("92667a4d-102e-4019-bc41-a620763d5a08"), 5, "D", "E", 3 },
                    { new Guid("20545c78-7d42-408c-94b2-7b2fa025a05e"), 50, "F", "D", 4 },
                    { new Guid("6c0b3e87-ddf0-4d93-a211-7c677ab99f59"), 50, "I", "F", 45 },
                    { new Guid("d6440eaa-c781-4901-9519-1760a9ed0d44"), 5, "B", "I", 65 },
                    { new Guid("5b98843b-e9df-40ab-847d-6e87144276e2"), 50, "G", "F", 40 },
                    { new Guid("70ef6c26-8305-422d-93dd-1ee9564c013d"), 73, "B", "G", 64 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Name", "PassCode", "Role" },
                values: new object[,]
                {
                    { new Guid("bacb6589-5eb4-4b85-b80f-94685d374e2d"), "Andre", "123456", "Admin" },
                    { new Guid("818aeb9f-7946-4db2-9023-3a5899b70d1e"), "Customer", "123456", "Customer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryPoint");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
