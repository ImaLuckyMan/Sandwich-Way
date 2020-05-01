using Microsoft.EntityFrameworkCore.Migrations;

namespace Sandwich_Way.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    SandwichesSandwichId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Sandwiches_SandwichesSandwichId",
                        column: x => x.SandwichesSandwichId,
                        principalTable: "Sandwiches",
                        principalColumn: "SandwichId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Classic_Italian_871x420.png", "\\Images\\Classic_Italian_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_871x420.png", "\\Images\\Turkey_Ranch_Swiss_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Tuna_Melt_871x420.png", "\\Images\\Tuna_Melt_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Veggie_Guac_871x420.png", "\\Images\\Veggie_Guac_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Spicy_Monterey_871x420.png", "\\Images\\Spicy_Monterey_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Chipotle_Turkey_871x420.png", "\\Images\\Chipotle_Turkey_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Ultimate_Turkey_Club_871x420.png", "\\Images\\Ultimate_Turkey_Club_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Honey_Bacon_Club_871x420.png", "\\Images\\Honey_Bacon_Club_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Turkey_Bacon_Guac_871x420.png", "\\Images\\Turkey_Bacon_Guac_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Traditional_871x420.png", "\\Images\\Traditional_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Baja_Chicken_871x410.png", "\\Images\\Baja_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "\\Images\\Apple_Harvest_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Honey_Mustard_Chicken_871x410.png", "\\Images\\Honey_Mustard_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Chicken_Carbonara_871x410.png", "\\Images\\Chicken_Carbonara_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Southwest_Chicken_871x410.png", "\\Images\\Southwest_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Mesquite_Chicken_871x410.png", "\\Images\\Mesquite_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Peppercorn_Steak_871x410.png", "\\Images\\Peppercorn_Steak_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_871x410.png", "\\Images\\Chiptole_Steak_Cheddar_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\French_Dip_871x410.png", "\\Images\\French_Dip_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Black_Angus_Steak_871x410.png", "\\Images\\Black_Angus_Steak_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "\\Images\\Apple_Harvest_Chicken_871x410.png" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SandwichesSandwichId",
                table: "ShoppingCartItems",
                column: "SandwichesSandwichId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Classic_Italian_871x420.png", "~\\Images\\Classic_Italian_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Turkey_Ranch_Swiss_871x420.png", "~\\Images\\Turkey_Ranch_Swiss_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Tuna_Melt_871x420.png", "~\\Images\\Tuna_Melt_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Veggie_Guac_871x420.png", "~\\Images\\Veggie_Guac_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Spicy_Monterey_871x420.png", "~\\Images\\Spicy_Monterey_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Chipotle_Turkey_871x420.png", "~\\Images\\Chipotle_Turkey_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Ultimate_Turkey_Club_871x420.png", "~\\Images\\Ultimate_Turkey_Club_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Honey_Bacon_Club_871x420.png", "~\\Images\\Honey_Bacon_Club_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Turkey_Bacon_Guac_871x420.png", "~\\Images\\Turkey_Bacon_Guac_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Traditional_871x420.png", "~\\Images\\Traditional_871x420.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Baja_Chicken_871x410.png", "~\\Images\\Baja_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "~\\Images\\Apple_Harvest_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Honey_Mustard_Chicken_871x410.png", "~\\Images\\Honey_Mustard_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Chicken_Carbonara_871x410.png", "~\\Images\\Chicken_Carbonara_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Southwest_Chicken_871x410.png", "~\\Images\\Southwest_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Mesquite_Chicken_871x410.png", "~\\Images\\Mesquite_Chicken_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Peppercorn_Steak_871x410.png", "~\\Images\\Peppercorn_Steak_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_871x410.png", "~\\Images\\Chiptole_Steak_Cheddar_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\French_Dip_871x410.png", "~\\Images\\French_Dip_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Black_Angus_Steak_871x410.png", "~\\Images\\Black_Angus_Steak_871x410.png" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "~\\Images\\Apple_Harvest_Chicken_871x410.png" });
        }
    }
}
