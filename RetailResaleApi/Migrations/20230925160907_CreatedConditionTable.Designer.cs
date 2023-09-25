﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailResaleApi.Context;

#nullable disable

namespace RetailResaleApi.Migrations
{
    [DbContext(typeof(RetailResaleContext))]
    [Migration("20230925160907_CreatedConditionTable")]
    partial class CreatedConditionTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = "Accessories"
                        },
                        new
                        {
                            Id = 2,
                            Value = "Dresses"
                        },
                        new
                        {
                            Id = 3,
                            Value = "Jackets/Coats"
                        },
                        new
                        {
                            Id = 4,
                            Value = "Jeans"
                        },
                        new
                        {
                            Id = 5,
                            Value = "Pants"
                        },
                        new
                        {
                            Id = 6,
                            Value = "Shirts/Tops"
                        },
                        new
                        {
                            Id = 7,
                            Value = "Shoes"
                        },
                        new
                        {
                            Id = 8,
                            Value = "Shorts"
                        },
                        new
                        {
                            Id = 9,
                            Value = "Skirts"
                        },
                        new
                        {
                            Id = 10,
                            Value = "Sweaters"
                        },
                        new
                        {
                            Id = 11,
                            Value = "Other"
                        });
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Condition");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Value = "Brand New"
                        },
                        new
                        {
                            Id = 2,
                            Value = "Like New"
                        },
                        new
                        {
                            Id = 3,
                            Value = "Used - Excellent"
                        },
                        new
                        {
                            Id = 4,
                            Value = "Used - Good"
                        },
                        new
                        {
                            Id = 5,
                            Value = "Used - Fair"
                        });
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Costs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Fee")
                        .HasColumnType("float");

                    b.Property<double>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<double?>("Shipping")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.ListingSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("ListingSite");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.ListingSiteProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateListed")
                        .HasColumnType("datetime2");

                    b.Property<double>("ListedPrice")
                        .HasColumnType("float");

                    b.Property<int>("ListingSiteId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UrlToListing")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ListingSiteId");

                    b.HasIndex("ProductId");

                    b.ToTable("ListingSiteProduct");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ConditionId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsSold")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("PurchasePrice")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("SizeType")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Sold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("Fee")
                        .HasColumnType("float");

                    b.Property<int>("ListingSiteProductId")
                        .HasColumnType("int");

                    b.Property<double?>("ShippingCost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("SoldDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SoldPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ListingSiteProductId");

                    b.ToTable("Sold");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Value = "Bags"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Value = "Belt"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Value = "Hat"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Value = "Scarf"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Value = "Sunglasses"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Value = "Suspenders"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Value = "Ties"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Value = "Watch"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Value = "Asymmetrical"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Value = "Backless"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Value = "High Low"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Value = "Long Sleeve"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Value = "Maxi"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Value = "Midi"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Value = "Mini"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Value = "One Shoulder"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 2,
                            Value = "Prom"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 2,
                            Value = "Strapless"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 2,
                            Value = "Wedding"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 2,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Value = "Blazer/SuitJacket"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            Value = "Bomber Jacket"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            Value = "Cape"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 3,
                            Value = "Denim Jacket"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 3,
                            Value = "Leather Jacket"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 3,
                            Value = "Pea Coat"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 3,
                            Value = "Parka"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 3,
                            Value = "Puffer"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 3,
                            Value = "Ski/Snow Jacket"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 3,
                            Value = "Trench Coat"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 3,
                            Value = "Utility Jacket"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 3,
                            Value = "Varsity Jacket"
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 3,
                            Value = "Vest"
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 3,
                            Value = "Windbreaker"
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 3,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 4,
                            Value = "Ankle/Cropped"
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 4,
                            Value = "Bootcut"
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 4,
                            Value = "Flare"
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 4,
                            Value = "High Waist"
                        },
                        new
                        {
                            Id = 41,
                            CategoryId = 4,
                            Value = "Skinny"
                        },
                        new
                        {
                            Id = 42,
                            CategoryId = 4,
                            Value = "Straight Leg"
                        },
                        new
                        {
                            Id = 43,
                            CategoryId = 4,
                            Value = "Wide Leg"
                        },
                        new
                        {
                            Id = 44,
                            CategoryId = 4,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 45,
                            CategoryId = 5,
                            Value = "Ankle/Cropped"
                        },
                        new
                        {
                            Id = 46,
                            CategoryId = 5,
                            Value = "Bootcut"
                        },
                        new
                        {
                            Id = 47,
                            CategoryId = 5,
                            Value = "Cargo"
                        },
                        new
                        {
                            Id = 48,
                            CategoryId = 5,
                            Value = "Chino"
                        },
                        new
                        {
                            Id = 49,
                            CategoryId = 5,
                            Value = "Corduroy"
                        },
                        new
                        {
                            Id = 51,
                            CategoryId = 5,
                            Value = "Flare"
                        },
                        new
                        {
                            Id = 52,
                            CategoryId = 5,
                            Value = "Jogger"
                        },
                        new
                        {
                            Id = 54,
                            CategoryId = 5,
                            Value = "Leggings"
                        },
                        new
                        {
                            Id = 56,
                            CategoryId = 5,
                            Value = "Patterned"
                        },
                        new
                        {
                            Id = 57,
                            CategoryId = 5,
                            Value = "Skinny"
                        },
                        new
                        {
                            Id = 58,
                            CategoryId = 5,
                            Value = "Straight Leg"
                        },
                        new
                        {
                            Id = 59,
                            CategoryId = 5,
                            Value = "Sweatpants"
                        },
                        new
                        {
                            Id = 60,
                            CategoryId = 5,
                            Value = "Trousers"
                        },
                        new
                        {
                            Id = 61,
                            CategoryId = 5,
                            Value = "Wide Leg"
                        },
                        new
                        {
                            Id = 62,
                            CategoryId = 5,
                            Value = "Workwear"
                        },
                        new
                        {
                            Id = 63,
                            CategoryId = 5,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 64,
                            CategoryId = 6,
                            Value = "Blouse"
                        },
                        new
                        {
                            Id = 65,
                            CategoryId = 6,
                            Value = "Bodysuit"
                        },
                        new
                        {
                            Id = 66,
                            CategoryId = 6,
                            Value = "Button Down"
                        },
                        new
                        {
                            Id = 67,
                            CategoryId = 6,
                            Value = "Crop Top"
                        },
                        new
                        {
                            Id = 68,
                            CategoryId = 6,
                            Value = "Cut Off"
                        },
                        new
                        {
                            Id = 69,
                            CategoryId = 6,
                            Value = "Hoodie"
                        },
                        new
                        {
                            Id = 70,
                            CategoryId = 6,
                            Value = "Polo"
                        },
                        new
                        {
                            Id = 71,
                            CategoryId = 6,
                            Value = "Sweatshirt"
                        },
                        new
                        {
                            Id = 72,
                            CategoryId = 6,
                            Value = "Tank Top"
                        },
                        new
                        {
                            Id = 73,
                            CategoryId = 6,
                            Value = "T-Shirt- Long Sleeve"
                        },
                        new
                        {
                            Id = 74,
                            CategoryId = 6,
                            Value = "T-Shirt- Short Sleeve"
                        },
                        new
                        {
                            Id = 75,
                            CategoryId = 6,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 76,
                            CategoryId = 7,
                            Value = "Ankle Boots"
                        },
                        new
                        {
                            Id = 77,
                            CategoryId = 7,
                            Value = "Combat Boot"
                        },
                        new
                        {
                            Id = 78,
                            CategoryId = 7,
                            Value = "Cowboy Boots"
                        },
                        new
                        {
                            Id = 79,
                            CategoryId = 7,
                            Value = "Flats/Loafers"
                        },
                        new
                        {
                            Id = 80,
                            CategoryId = 7,
                            Value = "Heeled Boots"
                        },
                        new
                        {
                            Id = 81,
                            CategoryId = 7,
                            Value = "High Heels"
                        },
                        new
                        {
                            Id = 82,
                            CategoryId = 7,
                            Value = "Mules/Clogs"
                        },
                        new
                        {
                            Id = 83,
                            CategoryId = 7,
                            Value = "Platforms"
                        },
                        new
                        {
                            Id = 84,
                            CategoryId = 7,
                            Value = "Sandals"
                        },
                        new
                        {
                            Id = 85,
                            CategoryId = 7,
                            Value = "Sneakers"
                        },
                        new
                        {
                            Id = 86,
                            CategoryId = 7,
                            Value = "Snow/Rain Boots"
                        },
                        new
                        {
                            Id = 87,
                            CategoryId = 7,
                            Value = "Wedges"
                        },
                        new
                        {
                            Id = 88,
                            CategoryId = 7,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 89,
                            CategoryId = 8,
                            Value = "Athletic"
                        },
                        new
                        {
                            Id = 90,
                            CategoryId = 8,
                            Value = "Bermuda"
                        },
                        new
                        {
                            Id = 91,
                            CategoryId = 8,
                            Value = "Bike Shorts"
                        },
                        new
                        {
                            Id = 92,
                            CategoryId = 8,
                            Value = "Cargo"
                        },
                        new
                        {
                            Id = 93,
                            CategoryId = 8,
                            Value = "Denim"
                        },
                        new
                        {
                            Id = 94,
                            CategoryId = 8,
                            Value = "High Waist"
                        },
                        new
                        {
                            Id = 95,
                            CategoryId = 8,
                            Value = "Skort"
                        },
                        new
                        {
                            Id = 96,
                            CategoryId = 8,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 97,
                            CategoryId = 9,
                            Value = "A-Line/Full"
                        },
                        new
                        {
                            Id = 98,
                            CategoryId = 9,
                            Value = "Asymetrical"
                        },
                        new
                        {
                            Id = 99,
                            CategoryId = 9,
                            Value = "Circle/Skater"
                        },
                        new
                        {
                            Id = 100,
                            CategoryId = 9,
                            Value = "High Low"
                        },
                        new
                        {
                            Id = 101,
                            CategoryId = 9,
                            Value = "Maxi"
                        },
                        new
                        {
                            Id = 102,
                            CategoryId = 9,
                            Value = "Midi"
                        },
                        new
                        {
                            Id = 103,
                            CategoryId = 9,
                            Value = "Mini"
                        },
                        new
                        {
                            Id = 104,
                            CategoryId = 9,
                            Value = "Pencil"
                        },
                        new
                        {
                            Id = 105,
                            CategoryId = 9,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 106,
                            CategoryId = 10,
                            Value = "Cardigan"
                        },
                        new
                        {
                            Id = 107,
                            CategoryId = 10,
                            Value = "Cowl Neck"
                        },
                        new
                        {
                            Id = 108,
                            CategoryId = 10,
                            Value = "Crew Neck"
                        },
                        new
                        {
                            Id = 109,
                            CategoryId = 10,
                            Value = "Off-the-Shoulder"
                        },
                        new
                        {
                            Id = 110,
                            CategoryId = 10,
                            Value = "Poncho"
                        },
                        new
                        {
                            Id = 111,
                            CategoryId = 10,
                            Value = "Scoop Neck"
                        },
                        new
                        {
                            Id = 112,
                            CategoryId = 10,
                            Value = "Shrugs"
                        },
                        new
                        {
                            Id = 113,
                            CategoryId = 10,
                            Value = "Turtleneck"
                        },
                        new
                        {
                            Id = 114,
                            CategoryId = 10,
                            Value = "V-Neck"
                        },
                        new
                        {
                            Id = 115,
                            CategoryId = 10,
                            Value = "Zip-Up"
                        },
                        new
                        {
                            Id = 116,
                            CategoryId = 10,
                            Value = "Other"
                        },
                        new
                        {
                            Id = 117,
                            CategoryId = 11,
                            Value = "Jumpsuit"
                        },
                        new
                        {
                            Id = 118,
                            CategoryId = 11,
                            Value = "Overalls"
                        },
                        new
                        {
                            Id = 119,
                            CategoryId = 11,
                            Value = "Coveralls"
                        },
                        new
                        {
                            Id = 120,
                            CategoryId = 11,
                            Value = "Two piece"
                        },
                        new
                        {
                            Id = 121,
                            CategoryId = 11,
                            Value = "Track suit"
                        });
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.ListingSiteProduct", b =>
                {
                    b.HasOne("RetailResaleApi.Data.Entities.ListingSite", "ListingSite")
                        .WithMany("ListingSiteProducts")
                        .HasForeignKey("ListingSiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailResaleApi.Data.Entities.Product", "Product")
                        .WithMany("ListingSiteProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListingSite");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Product", b =>
                {
                    b.HasOne("RetailResaleApi.Data.Entities.Condition", "Condition")
                        .WithMany()
                        .HasForeignKey("ConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailResaleApi.Data.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condition");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Sold", b =>
                {
                    b.HasOne("RetailResaleApi.Data.Entities.ListingSiteProduct", "ListingSiteProduct")
                        .WithMany()
                        .HasForeignKey("ListingSiteProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ListingSiteProduct");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.SubCategory", b =>
                {
                    b.HasOne("RetailResaleApi.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.ListingSite", b =>
                {
                    b.Navigation("ListingSiteProducts");
                });

            modelBuilder.Entity("RetailResaleApi.Data.Entities.Product", b =>
                {
                    b.Navigation("ListingSiteProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
