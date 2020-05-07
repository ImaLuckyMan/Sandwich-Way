using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sandwich_Way.Migrations
{
    public partial class AddingAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(maxLength: 12, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    SandwichId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Sandwiches_SandwichId",
                        column: x => x.SandwichId,
                        principalTable: "Sandwiches",
                        principalColumn: "SandwichId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Classic_Italian_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Tuna_Melt_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Veggie_Guac_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Spicy_Monterey_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chipotle_Turkey_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Ultimate_Turkey_Club_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Honey_Bacon_Club_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Turkey_Bacon_Guac_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Traditional_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Baja_Chicken_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Honey_Mustard_Chicken_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chicken_Carbonara_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Southwest_Chicken_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Mesquite_Chicken_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Peppercorn_Steak_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\French_Dip_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Black_Angus_Steak_small.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SandwichId",
                table: "OrderDetails",
                column: "SandwichId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Classic_Italian_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Tuna_Melt_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Veggie_Guac_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Spicy_Monterey_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chipotle_Turkey_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Ultimate_Turkey_Club_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Honey_Bacon_Club_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 9,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Turkey_Bacon_Guac_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Traditional_871x420.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Baja_Chicken_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Honey_Mustard_Chicken_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chicken_Carbonara_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Southwest_Chicken_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Mesquite_Chicken_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Peppercorn_Steak_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\French_Dip_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Black_Angus_Steak_871x410.png");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                column: "ImageThumbnailUrl",
                value: "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png");
        }
    }
}
