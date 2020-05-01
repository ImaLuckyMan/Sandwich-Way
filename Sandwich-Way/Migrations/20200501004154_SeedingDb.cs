using Microsoft.EntityFrameworkCore.Migrations;

namespace Sandwich_Way.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Classic" },
                    { 2, null, "Premium" },
                    { 3, null, "Chicken" },
                    { 4, null, "Steak" },
                    { 5, null, "Salads" }
                });

            migrationBuilder.InsertData(
                table: "Sandwiches",
                columns: new[] { "SandwichId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Price", "SandwichName" },
                values: new object[,]
                {
                    { 1, 1, "Pepperoni, salami, capicola, ham, provolone, black olives, banana peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people", "\\Images\\Thumbnails\\Classic_Italian_871x420.png", "\\Images\\Classic_Italian_871x420.png", true, false, 4.95m, "Classic Italian" },
                    { 19, 4, "Black angus steak, Swiss, sautéed onions, creamy horseradish, side of au jus - For Rich People", "\\Images\\Thumbnails\\French_Dip_871x410.png", "\\Images\\French_Dip_871x410.png", true, false, 7.95m, "French Dip" },
                    { 18, 4, "with sautéed peppers & onions, chipotle mayo - For Rich People", "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_871x410.png", "\\Images\\Chiptole_Steak_Cheddar_871x410.png", true, false, 7.95m, "Chiptole Steak and Cheddar" },
                    { 17, 4, "with provolone, sautéed onions, peppercorn sauce - For Rich People", "\\Images\\Thumbnails\\Peppercorn_Steak_871x410.png", "\\Images\\Peppercorn_Steak_871x410.png", true, false, 7.95m, "Peppercorn Steak" },
                    { 16, 3, "with bacon, cheddar, lettuce, tomatoes, onions, ranch - The other White Meat", "\\Images\\Thumbnails\\Mesquite_Chicken_871x410.png", "\\Images\\Mesquite_Chicken_871x410.png", true, false, 6.95m, "Mesquite Chicken" },
                    { 15, 3, "with cheddar, guacamole, chipotle mayo - The other White Meat", "\\Images\\Thumbnails\\Southwest_Chicken_871x410.png", "\\Images\\Southwest_Chicken_871x410.png", true, false, 6.95m, "Southwest Chicken" },
                    { 14, 3, "with bacon, provolone, sautéed mushrooms, parmesan alfredo sauce - The other White Meat", "\\Images\\Thumbnails\\Chicken_Carbonara_871x410.png", "\\Images\\Chicken_Carbonara_871x410.png", true, false, 6.95m, "Chicken Carbonara" },
                    { 13, 3, "with bacon, Swiss, lettuce, tomatoes, onions - The other White Meat", "\\Images\\Thumbnails\\Honey_Mustard_Chicken_871x410.png", "\\Images\\Honey_Mustard_Chicken_871x410.png", true, false, 6.95m, "Honey Mustard Chicken" },
                    { 12, 3, "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, lettuce, tomatoes, pumpkin seeds, honey mustard dressing - The other White Meat", "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "\\Images\\Apple_Harvest_Chicken_871x410.png", true, false, 6.95m, "Apple Harvest Chicken" },
                    { 20, 4, "with provolone, cheddar, sautéed mushrooms & onions, zesty grille sauce on rosemary parmesan bread - For Rich People", "\\Images\\Thumbnails\\Black_Angus_Steak_871x410.png", "\\Images\\Black_Angus_Steak_871x410.png", true, false, 7.95m, "Black Angus Steakhouse" },
                    { 11, 3, "with bacon, cheddar, onions, BBQ sauce, chipotle mayo - The other White Meat", "\\Images\\Thumbnails\\Baja_Chicken_871x410.png", "\\Images\\Baja_Chicken_871x410.png", true, false, 6.95m, "Baja Chicken" },
                    { 9, 2, "with provolone, lettuce, tomatoes, onions, ranch - For Stuck-Up People", "\\Images\\Thumbnails\\Turkey_Bacon_Guac_871x420.png", "\\Images\\Turkey_Bacon_Guac_871x420.png", true, false, 5.95m, "Turkey Bacon Guacamole" },
                    { 8, 2, "Turkey, ham, bacon, Swiss, lettuce, tomatoes, onions, honey-french dressing - For Stuck-Up People", "\\Images\\Thumbnails\\Honey_Bacon_Club_871x420.png", "\\Images\\Honey_Bacon_Club_871x420.png", true, false, 5.95m, "Honey Bacon Club" },
                    { 7, 2, "with bacon, cheddar, lettuce, tomatoes, mayo - For Stuck-Up People", "\\Images\\Thumbnails\\Ultimate_Turkey_Club_871x420.png", "\\Images\\Ultimate_Turkey_Club_871x420.png", true, false, 5.95m, "Ultimate Turkey Club" },
                    { 6, 2, "with cheddar, lettuce, tomatoes, onions, chipotle mayo - For Stuck-Up People", "\\Images\\Thumbnails\\Chipotle_Turkey_871x420.png", "\\Images\\Chipotle_Turkey_871x420.png", true, false, 5.95m, "Chipotle Turkey" },
                    { 5, 1, "Turkey, ham, provolone, pickles, lettuce, tomatoes, mayo, four pepper chili sauce - For boring people", "\\Images\\Thumbnails\\Spicy_Monterey_871x420.png", "\\Images\\Spicy_Monterey_871x420.png", true, false, 4.95m, "Spicy Monterey" },
                    { 4, 1, "with cheddar, provolone, black olives, cucumbers, mushrooms, green peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people", "\\Images\\Thumbnails\\Veggie_Guac_871x420.png", "\\Images\\Veggie_Guac_871x420.png", true, false, 4.95m, "Veggie Guacamole" },
                    { 3, 1, "Tuna salad, cheddar, pickles, tomatoes - For boring people", "\\Images\\Thumbnails\\Tuna_Melt_871x420.png", "\\Images\\Tuna_Melt_871x420.png", true, false, 4.95m, "Tuna Melt" },
                    { 2, 1, "with lettuce, tomatoes, onions - For boring people", "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_871x420.png", "\\Images\\Turkey_Ranch_Swiss_871x420.png", true, false, 4.95m, "Turkey Ranch and Swiss" },
                    { 10, 2, "Black angus steak, turkey, ham, cheddar, black olives, lettuce, tomatoes, onions, ranch - For Stuck-Up People", "\\Images\\Thumbnails\\Traditional_871x420.png", "\\Images\\Traditional_871x420.png", true, false, 5.95m, "Traditional" },
                    { 21, 5, "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, tomatoes, pumpkin seeds, acai vinaigrette - For People that eat my foods food", "\\Images\\Thumbnails\\Apple_Harvest_Chicken_871x410.png", "~\\Images\\Apple_Harvest_Chicken_871x410.png", true, false, 3.95m, "Apple Harvest Chicken Salad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);
        }
    }
}
