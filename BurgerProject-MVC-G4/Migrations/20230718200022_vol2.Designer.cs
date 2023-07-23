﻿// <auto-generated />
using System;
using BurgerProject_MVC_G4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerProject_MVC_G4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230718200022_vol2")]
    partial class vol2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"), 1L, 1);

                    b.Property<string>("AddressDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.HasKey("AddressID");

                    b.HasIndex("AppUserID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "3bd6d196-0e0f-4d9b-9723-0eac7111ff81",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "7f2143c0-7899-4cc6-8323-a2a2d2a008a0",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"), 1L, 1);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("UserMenuID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductsID");

                    b.HasIndex("UserMenuID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Burger"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Potatoes"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Sauce"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Beverage"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Extra"
                        });
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Garniture", b =>
                {
                    b.Property<int>("GarnitureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GarnitureID"), 1L, 1);

                    b.Property<string>("GarnitureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GarnitureID");

                    b.ToTable("Garnitures");

                    b.HasData(
                        new
                        {
                            GarnitureID = 1,
                            GarnitureName = "Tomatoes"
                        },
                        new
                        {
                            GarnitureID = 2,
                            GarnitureName = "Ketchup"
                        },
                        new
                        {
                            GarnitureID = 3,
                            GarnitureName = "Mayonnaise"
                        },
                        new
                        {
                            GarnitureID = 4,
                            GarnitureName = "Barbeque"
                        },
                        new
                        {
                            GarnitureID = 5,
                            GarnitureName = "Lettuce"
                        },
                        new
                        {
                            GarnitureID = 6,
                            GarnitureName = "Onion"
                        },
                        new
                        {
                            GarnitureID = 7,
                            GarnitureName = "Cheese"
                        });
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"), 1L, 1);

                    b.Property<decimal?>("BigPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MiddlePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SmallPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MenuID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuID = 1,
                            BigPrice = 230m,
                            CoverImage = "1BigKingMenu.png",
                            MenuName = "BigKing Menu",
                            MiddlePrice = 210m,
                            SmallPrice = 190m
                        },
                        new
                        {
                            MenuID = 2,
                            BigPrice = 200m,
                            CoverImage = "2BigTastyMenu.png",
                            MenuName = "BigTasty Menu",
                            MiddlePrice = 180m,
                            SmallPrice = 160m
                        },
                        new
                        {
                            MenuID = 3,
                            BigPrice = 210m,
                            CoverImage = "3WhooperMenu.png",
                            MenuName = "Whooper Menu",
                            MiddlePrice = 190m,
                            SmallPrice = 170m
                        },
                        new
                        {
                            MenuID = 4,
                            BigPrice = 190m,
                            CoverImage = "4ClassicMenu.png",
                            MenuName = "Classic Menu",
                            MiddlePrice = 170m,
                            SmallPrice = 150m
                        },
                        new
                        {
                            MenuID = 5,
                            BigPrice = 230m,
                            CoverImage = "5DoubleQuarterMenu.png",
                            MenuName = "Double Quarter Menu",
                            MiddlePrice = 210m,
                            SmallPrice = 190m
                        },
                        new
                        {
                            MenuID = 6,
                            BigPrice = 210m,
                            CoverImage = "6CheeseBurgerMenu.png",
                            MenuName = "Cheese Burger Menu",
                            MiddlePrice = 190m,
                            SmallPrice = 170m
                        });
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserMassage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.HasIndex("AddressID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            CategoryID = 3,
                            CoverImage = "3Barbeque.png",
                            Price = 10m,
                            ProductName = "Barbeque"
                        },
                        new
                        {
                            ProductID = 2,
                            CategoryID = 1,
                            CoverImage = "1BigKing.png",
                            Price = 150m,
                            ProductName = "BigKing"
                        },
                        new
                        {
                            ProductID = 3,
                            CategoryID = 1,
                            CoverImage = "2BigTasty.png",
                            Price = 120m,
                            ProductName = "BigTasty"
                        },
                        new
                        {
                            ProductID = 4,
                            CategoryID = 1,
                            CoverImage = "3Whooper.png",
                            Price = 130m,
                            ProductName = "Whooper"
                        },
                        new
                        {
                            ProductID = 5,
                            CategoryID = 1,
                            CoverImage = "4Classic.png",
                            Price = 110m,
                            ProductName = "Classic"
                        },
                        new
                        {
                            ProductID = 6,
                            CategoryID = 1,
                            CoverImage = "5DoubleQuarter.png",
                            Price = 150m,
                            ProductName = "Double Quarter"
                        },
                        new
                        {
                            ProductID = 7,
                            CategoryID = 1,
                            CoverImage = "6CheeseBurger.png",
                            Price = 130m,
                            ProductName = "Cheese Burger"
                        },
                        new
                        {
                            ProductID = 8,
                            CategoryID = 5,
                            CoverImage = "1Nugget.png",
                            Price = 40m,
                            ProductName = "Nugget"
                        },
                        new
                        {
                            ProductID = 9,
                            CategoryID = 5,
                            CoverImage = "2OnionRing.png",
                            Price = 40m,
                            ProductName = "Onion Ring"
                        },
                        new
                        {
                            ProductID = 10,
                            CategoryID = 5,
                            CoverImage = "3Schnitzel.png",
                            Price = 40m,
                            ProductName = "Schnitzel"
                        },
                        new
                        {
                            ProductID = 11,
                            CategoryID = 2,
                            CoverImage = "1FrenchFries.png",
                            Price = 30m,
                            ProductName = "French Fries"
                        },
                        new
                        {
                            ProductID = 12,
                            CategoryID = 2,
                            CoverImage = "2Scalloped.png",
                            Price = 30m,
                            ProductName = "Scalloped"
                        },
                        new
                        {
                            ProductID = 13,
                            CategoryID = 4,
                            CoverImage = "1CocaCola.png",
                            Price = 30m,
                            ProductName = "CocaCola"
                        },
                        new
                        {
                            ProductID = 14,
                            CategoryID = 4,
                            CoverImage = "2Fanta.png",
                            Price = 30m,
                            ProductName = "Fanta"
                        },
                        new
                        {
                            ProductID = 15,
                            CategoryID = 4,
                            CoverImage = "3Sprite.png",
                            Price = 30m,
                            ProductName = "Sprite"
                        },
                        new
                        {
                            ProductID = 16,
                            CategoryID = 4,
                            CoverImage = "4Beer.png",
                            Price = 30m,
                            ProductName = "Beer"
                        },
                        new
                        {
                            ProductID = 17,
                            CategoryID = 3,
                            CoverImage = "1Mayonnaise.png",
                            Price = 10m,
                            ProductName = "Mayonnaise"
                        },
                        new
                        {
                            ProductID = 18,
                            CategoryID = 3,
                            CoverImage = "2Ketchup.png",
                            Price = 10m,
                            ProductName = "Ketchup"
                        });
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.ProductUserMenu", b =>
                {
                    b.Property<int>("ProductUserMenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductUserMenuID"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("UserMenuID")
                        .HasColumnType("int");

                    b.HasKey("ProductUserMenuID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserMenuID");

                    b.ToTable("ProductsUserMenus");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.UserMenu", b =>
                {
                    b.Property<int>("UserMenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserMenuID"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("UserMenuID");

                    b.ToTable("UserMenus");
                });

            modelBuilder.Entity("GarnitureProduct", b =>
                {
                    b.Property<int>("GarnituresGarnitureID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductID")
                        .HasColumnType("int");

                    b.HasKey("GarnituresGarnitureID", "ProductsProductID");

                    b.HasIndex("ProductsProductID");

                    b.ToTable("GarnitureProduct");
                });

            modelBuilder.Entity("MenuProduct", b =>
                {
                    b.Property<int>("MenusMenuID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductID")
                        .HasColumnType("int");

                    b.HasKey("MenusMenuID", "ProductsProductID");

                    b.HasIndex("ProductsProductID");

                    b.ToTable("MenuProduct");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Address", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", "AppUser")
                        .WithMany("Addresses")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Cart", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", "AppUser")
                        .WithMany("Carts")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Menu", "Menu")
                        .WithMany("Carts")
                        .HasForeignKey("MenuID");

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Order", "Order")
                        .WithMany("Carts")
                        .HasForeignKey("OrderID");

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Product", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsID");

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.UserMenu", "UserMenu")
                        .WithMany()
                        .HasForeignKey("UserMenuID");

                    b.Navigation("AppUser");

                    b.Navigation("Menu");

                    b.Navigation("Order");

                    b.Navigation("Products");

                    b.Navigation("UserMenu");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Order", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Product", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.ProductUserMenu", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Product", "Product")
                        .WithMany("UserMenus")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.UserMenu", "UserMenu")
                        .WithMany("Products")
                        .HasForeignKey("UserMenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("UserMenu");
                });

            modelBuilder.Entity("GarnitureProduct", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Garniture", null)
                        .WithMany()
                        .HasForeignKey("GarnituresGarnitureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MenuProduct", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenusMenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BurgerProject_MVC_G4.Models.Entites.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.AppUser", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Carts");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Menu", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Order", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.Product", b =>
                {
                    b.Navigation("UserMenus");
                });

            modelBuilder.Entity("BurgerProject_MVC_G4.Models.Entites.UserMenu", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
