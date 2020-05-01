using Microsoft.EntityFrameworkCore.Migrations;

namespace Sandwich_Way.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Sandwiches",
                columns: table => new
                {
                    SandwichId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SandwichName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsOnSale = table.Column<bool>(nullable: false),
                    IsInStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sandwiches", x => x.SandwichId);
                    table.ForeignKey(
                        name: "FK_Sandwiches_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sandwiches_CategoryId",
                table: "Sandwiches",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sandwiches");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
