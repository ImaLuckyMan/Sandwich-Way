﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sandwich_Way.Models;

namespace Sandwich_Way.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sandwich_Way.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Classic"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Premium"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Chicken"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Steak"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Salads"
                        });
                });

            modelBuilder.Entity("Sandwich_Way.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Sandwich_Way.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SandwichId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("SandwichId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Sandwich_Way.Models.Sandwiches", b =>
                {
                    b.Property<int>("SandwichId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SandwichName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SandwichId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sandwiches");

                    b.HasData(
                        new
                        {
                            SandwichId = 1,
                            CategoryId = 1,
                            Description = "Pepperoni, salami, capicola, ham, provolone, black olives, banana peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Classic_Italian_small.png",
                            ImageUrl = "\\Images\\Classic_Italian_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 4.95m,
                            SandwichName = "Classic Italian"
                        },
                        new
                        {
                            SandwichId = 2,
                            CategoryId = 1,
                            Description = "with lettuce, tomatoes, onions - For boring people",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Turkey_Ranch_Swiss_small.png",
                            ImageUrl = "\\Images\\Turkey_Ranch_Swiss_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 4.95m,
                            SandwichName = "Turkey Ranch and Swiss"
                        },
                        new
                        {
                            SandwichId = 3,
                            CategoryId = 1,
                            Description = "Tuna salad, cheddar, pickles, tomatoes - For boring people",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Tuna_Melt_small.png",
                            ImageUrl = "\\Images\\Tuna_Melt_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 4.95m,
                            SandwichName = "Tuna Melt"
                        },
                        new
                        {
                            SandwichId = 4,
                            CategoryId = 1,
                            Description = "with cheddar, provolone, black olives, cucumbers, mushrooms, green peppers, lettuce, tomatoes, onions, red wine vinaigrette - For boring people",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Veggie_Guac_small.png",
                            ImageUrl = "\\Images\\Veggie_Guac_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 4.95m,
                            SandwichName = "Veggie Guacamole"
                        },
                        new
                        {
                            SandwichId = 5,
                            CategoryId = 1,
                            Description = "Turkey, ham, provolone, pickles, lettuce, tomatoes, mayo, four pepper chili sauce - For boring people",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Spicy_Monterey_small.png",
                            ImageUrl = "\\Images\\Spicy_Monterey_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 4.95m,
                            SandwichName = "Spicy Monterey"
                        },
                        new
                        {
                            SandwichId = 6,
                            CategoryId = 2,
                            Description = "with cheddar, lettuce, tomatoes, onions, chipotle mayo - For Stuck-Up People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Chipotle_Turkey_small.png",
                            ImageUrl = "\\Images\\Chipotle_Turkey_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 5.95m,
                            SandwichName = "Chipotle Turkey"
                        },
                        new
                        {
                            SandwichId = 7,
                            CategoryId = 2,
                            Description = "with bacon, cheddar, lettuce, tomatoes, mayo - For Stuck-Up People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Ultimate_Turkey_Club_small.png",
                            ImageUrl = "\\Images\\Ultimate_Turkey_Club_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 5.95m,
                            SandwichName = "Ultimate Turkey Club"
                        },
                        new
                        {
                            SandwichId = 8,
                            CategoryId = 2,
                            Description = "Turkey, ham, bacon, Swiss, lettuce, tomatoes, onions, honey-french dressing - For Stuck-Up People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Honey_Bacon_Club_small.png",
                            ImageUrl = "\\Images\\Honey_Bacon_Club_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 5.95m,
                            SandwichName = "Honey Bacon Club"
                        },
                        new
                        {
                            SandwichId = 9,
                            CategoryId = 2,
                            Description = "with provolone, lettuce, tomatoes, onions, ranch - For Stuck-Up People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Turkey_Bacon_Guac_small.png",
                            ImageUrl = "\\Images\\Turkey_Bacon_Guac_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 5.95m,
                            SandwichName = "Turkey Bacon Guacamole"
                        },
                        new
                        {
                            SandwichId = 10,
                            CategoryId = 2,
                            Description = "Black angus steak, turkey, ham, cheddar, black olives, lettuce, tomatoes, onions, ranch - For Stuck-Up People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Traditional_small.png",
                            ImageUrl = "\\Images\\Traditional_871x420.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 5.95m,
                            SandwichName = "Traditional"
                        },
                        new
                        {
                            SandwichId = 11,
                            CategoryId = 3,
                            Description = "with bacon, cheddar, onions, BBQ sauce, chipotle mayo - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Baja_Chicken_small.png",
                            ImageUrl = "\\Images\\Baja_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Baja Chicken"
                        },
                        new
                        {
                            SandwichId = 12,
                            CategoryId = 3,
                            Description = "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, lettuce, tomatoes, pumpkin seeds, honey mustard dressing - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png",
                            ImageUrl = "\\Images\\Apple_Harvest_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Apple Harvest Chicken"
                        },
                        new
                        {
                            SandwichId = 13,
                            CategoryId = 3,
                            Description = "with bacon, Swiss, lettuce, tomatoes, onions - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Honey_Mustard_Chicken_small.png",
                            ImageUrl = "\\Images\\Honey_Mustard_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Honey Mustard Chicken"
                        },
                        new
                        {
                            SandwichId = 14,
                            CategoryId = 3,
                            Description = "with bacon, provolone, sautéed mushrooms, parmesan alfredo sauce - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Chicken_Carbonara_small.png",
                            ImageUrl = "\\Images\\Chicken_Carbonara_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Chicken Carbonara"
                        },
                        new
                        {
                            SandwichId = 15,
                            CategoryId = 3,
                            Description = "with cheddar, guacamole, chipotle mayo - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Southwest_Chicken_small.png",
                            ImageUrl = "\\Images\\Southwest_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Southwest Chicken"
                        },
                        new
                        {
                            SandwichId = 16,
                            CategoryId = 3,
                            Description = "with bacon, cheddar, lettuce, tomatoes, onions, ranch - The other White Meat",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Mesquite_Chicken_small.png",
                            ImageUrl = "\\Images\\Mesquite_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 6.95m,
                            SandwichName = "Mesquite Chicken"
                        },
                        new
                        {
                            SandwichId = 17,
                            CategoryId = 4,
                            Description = "with provolone, sautéed onions, peppercorn sauce - For Rich People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Peppercorn_Steak_small.png",
                            ImageUrl = "\\Images\\Peppercorn_Steak_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 7.95m,
                            SandwichName = "Peppercorn Steak"
                        },
                        new
                        {
                            SandwichId = 18,
                            CategoryId = 4,
                            Description = "with sautéed peppers & onions, chipotle mayo - For Rich People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Chiptole_Steak_Cheddar_small.png",
                            ImageUrl = "\\Images\\Chiptole_Steak_Cheddar_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 7.95m,
                            SandwichName = "Chiptole Steak and Cheddar"
                        },
                        new
                        {
                            SandwichId = 19,
                            CategoryId = 4,
                            Description = "Black angus steak, Swiss, sautéed onions, creamy horseradish, side of au jus - For Rich People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\French_Dip_small.png",
                            ImageUrl = "\\Images\\French_Dip_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 7.95m,
                            SandwichName = "French Dip"
                        },
                        new
                        {
                            SandwichId = 20,
                            CategoryId = 4,
                            Description = "with provolone, cheddar, sautéed mushrooms & onions, zesty grille sauce on rosemary parmesan bread - For Rich People",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Black_Angus_Steak_small.png",
                            ImageUrl = "\\Images\\Black_Angus_Steak_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 7.95m,
                            SandwichName = "Black Angus Steakhouse"
                        },
                        new
                        {
                            SandwichId = 21,
                            CategoryId = 5,
                            Description = "Honey-dijon chicken salad, apples, dried cranberries, cucumbers, tomatoes, pumpkin seeds, acai vinaigrette - For People that eat my foods food",
                            ImageThumbnailUrl = "\\Images\\Thumbnails\\Apple_Harvest_Chicken_small.png",
                            ImageUrl = "\\Images\\Apple_Harvest_Chicken_871x410.png",
                            IsInStock = true,
                            IsOnSale = false,
                            Price = 3.95m,
                            SandwichName = "Apple Harvest Chicken Salad"
                        });
                });

            modelBuilder.Entity("Sandwich_Way.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("SandwichesSandwichId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("SandwichesSandwichId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sandwich_Way.Models.OrderDetail", b =>
                {
                    b.HasOne("Sandwich_Way.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich_Way.Models.Sandwiches", "Sandwich")
                        .WithMany()
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sandwich_Way.Models.Sandwiches", b =>
                {
                    b.HasOne("Sandwich_Way.Models.Category", "Category")
                        .WithMany("Sandwiches")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sandwich_Way.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Sandwich_Way.Models.Sandwiches", "Sandwiches")
                        .WithMany()
                        .HasForeignKey("SandwichesSandwichId");
                });
#pragma warning restore 612, 618
        }
    }
}
