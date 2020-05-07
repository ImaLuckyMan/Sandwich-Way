using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sandwich_Way.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Sandwiches> Sandwiches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 1, CategoryName = "Classic" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 2, CategoryName = "Premium" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 3, CategoryName = "Chicken" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 4, CategoryName = "Steak" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 5, CategoryName = "Salads" });

            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 1,
                SandwichName = "Classic Italian",
                Price = 4.95M,
                Description = "Pepperoni, salami, capicola, ham, provolone, black olives, banana peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people",
                CategoryId = 1,
                ImageUrl="\\Images\\Classic_Italian_871x420.png",
                ImageThumbnailUrl= "\\Images\\Thumbnails\\Classic_Italian_small.png",
                IsInStock=true,
                IsOnSale=false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 2,
                SandwichName = "Turkey Ranch and Swiss",
                Price = 4.95M,
                Description = "with lettuce, tomatoes, onions - For boring people",
                CategoryId = 1,
                ImageUrl = "\\Images\\Turkey_Ranch_Swiss_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 3,
                SandwichName = "Tuna Melt",
                Price = 4.95M,
                Description = "Tuna salad, cheddar, pickles, tomatoes - For boring people",
                CategoryId = 1,
                ImageUrl = "\\Images\\Tuna_Melt_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Tuna_Melt_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 4,
                SandwichName = "Veggie Guacamole",
                Price = 4.95M,
                Description = "with cheddar, provolone, black olives, cucumbers, mushrooms, green peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people",
                CategoryId = 1,
                ImageUrl = "\\Images\\Veggie_Guac_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Veggie_Guac_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 5,
                SandwichName = "Spicy Monterey",
                Price = 4.95M,
                Description = "Turkey, ham, provolone, pickles, lettuce, tomatoes, mayo, four pepper chili sauce - For boring people",
                CategoryId = 1,
                ImageUrl = "\\Images\\Spicy_Monterey_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Spicy_Monterey_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 6,
                SandwichName = "Chipotle Turkey",
                Price = 5.95M,
                Description = "with cheddar, lettuce, tomatoes, onions, chipotle mayo - For Stuck-Up People",
                CategoryId = 2,
                ImageUrl = "\\Images\\Chipotle_Turkey_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Chipotle_Turkey_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 7,
                SandwichName = "Ultimate Turkey Club",
                Price = 5.95M,
                Description = "with bacon, cheddar, lettuce, tomatoes, mayo - For Stuck-Up People",
                CategoryId = 2,
                ImageUrl = "\\Images\\Ultimate_Turkey_Club_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Ultimate_Turkey_Club_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 8,
                SandwichName = "Honey Bacon Club",
                Price = 5.95M,
                Description = "Turkey, ham, bacon, Swiss, lettuce, tomatoes, onions, honey-french dressing - For Stuck-Up People",
                CategoryId = 2,
                ImageUrl = "\\Images\\Honey_Bacon_Club_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Honey_Bacon_Club_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 9,
                SandwichName = "Turkey Bacon Guacamole",
                Price = 5.95M,
                Description = "with provolone, lettuce, tomatoes, onions, ranch - For Stuck-Up People",
                CategoryId = 2,
                ImageUrl = "\\Images\\Turkey_Bacon_Guac_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Turkey_Bacon_Guac_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 10,
                SandwichName = "Traditional",
                Price = 5.95M,
                Description = "Black angus steak, turkey, ham, cheddar, black olives, lettuce, tomatoes, onions, ranch - For Stuck-Up People",
                CategoryId = 2,
                ImageUrl = "\\Images\\Traditional_871x420.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Traditional_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 11,
                SandwichName = "Baja Chicken",
                Price = 6.95M,
                Description = "with bacon, cheddar, onions, BBQ sauce, chipotle mayo - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Baja_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Baja_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 12,
                SandwichName = "Apple Harvest Chicken",
                Price = 6.95M,
                Description = "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, lettuce, tomatoes, pumpkin seeds, honey mustard dressing - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Apple_Harvest_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 13,
                SandwichName = "Honey Mustard Chicken",
                Price = 6.95M,
                Description = "with bacon, Swiss, lettuce, tomatoes, onions - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Honey_Mustard_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Honey_Mustard_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 14,
                SandwichName = "Chicken Carbonara",
                Price = 6.95M,
                Description = "with bacon, provolone, sautéed mushrooms, parmesan alfredo sauce - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Chicken_Carbonara_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Chicken_Carbonara_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 15,
                SandwichName = "Southwest Chicken",
                Price = 6.95M,
                Description = "with cheddar, guacamole, chipotle mayo - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Southwest_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Southwest_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 16,
                SandwichName = "Mesquite Chicken",
                Price = 6.95M,
                Description = "with bacon, cheddar, lettuce, tomatoes, onions, ranch - The other White Meat",
                CategoryId = 3,
                ImageUrl = "\\Images\\Mesquite_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Mesquite_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 17,
                SandwichName = "Peppercorn Steak",
                Price = 7.95M,
                Description = "with provolone, sautéed onions, peppercorn sauce - For Rich People",
                CategoryId = 4,
                ImageUrl = "\\Images\\Peppercorn_Steak_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Peppercorn_Steak_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 18,
                SandwichName = "Chiptole Steak and Cheddar",
                Price = 7.95M,
                Description = "with sautéed peppers & onions, chipotle mayo - For Rich People",
                CategoryId = 4,
                ImageUrl = "\\Images\\Chiptole_Steak_Cheddar_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 19,
                SandwichName = "French Dip",
                Price = 7.95M,
                Description = "Black angus steak, Swiss, sautéed onions, creamy horseradish, side of au jus - For Rich People",
                CategoryId = 4,
                ImageUrl = "\\Images\\French_Dip_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\French_Dip_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 20,
                SandwichName = "Black Angus Steakhouse",
                Price = 7.95M,
                Description = "with provolone, cheddar, sautéed mushrooms & onions, zesty grille sauce on rosemary parmesan bread - For Rich People",
                CategoryId = 4,
                ImageUrl = "\\Images\\Black_Angus_Steak_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Black_Angus_Steak_small.png",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Sandwiches>().HasData(new Sandwiches
            {
                SandwichId = 21,
                SandwichName = "Apple Harvest Chicken Salad",
                Price = 3.95M,
                Description = "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, tomatoes, pumpkin seeds, acai vinaigrette - For People that eat my foods food",
                CategoryId = 5,
                ImageUrl = "\\Images\\Apple_Harvest_Chicken_871x410.png",
                ImageThumbnailUrl = "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png",
                IsInStock = true,
                IsOnSale = false
            });

        }
    }
}
