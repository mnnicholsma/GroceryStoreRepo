﻿// <auto-generated />
using System;
using GroceryStoreAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStoreAPI.Migrations
{
    [DbContext(typeof(GrocertyStoreContext))]
    partial class GrocertyStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryStoreAPI.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1942, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joe",
                            LastName = "Biden"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1946, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Donald",
                            LastName = "Trump"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1961, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Barack",
                            LastName = "Obama"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1946, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "George",
                            LastName = "Bush"
                        });
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ItemName = "Apple",
                            Quantity = 1,
                            TripId = 1
                        },
                        new
                        {
                            Id = 2,
                            ItemName = "Milk",
                            Quantity = 1,
                            TripId = 1
                        },
                        new
                        {
                            Id = 3,
                            ItemName = "Fruity Pebbles",
                            Quantity = 1,
                            TripId = 1
                        },
                        new
                        {
                            Id = 4,
                            ItemName = "Oatmeal",
                            Quantity = 2,
                            TripId = 1
                        },
                        new
                        {
                            Id = 5,
                            ItemName = "Bread",
                            Quantity = 1,
                            TripId = 2
                        },
                        new
                        {
                            Id = 6,
                            ItemName = "Bagels",
                            Quantity = 1,
                            TripId = 2
                        },
                        new
                        {
                            Id = 7,
                            ItemName = "Out Milk",
                            Quantity = 3,
                            TripId = 2
                        },
                        new
                        {
                            Id = 8,
                            ItemName = "Apple Juice",
                            Quantity = 1,
                            TripId = 2
                        },
                        new
                        {
                            Id = 9,
                            ItemName = "Orange Juice",
                            Quantity = 1,
                            TripId = 3
                        },
                        new
                        {
                            Id = 10,
                            ItemName = "Grapes",
                            Quantity = 1,
                            TripId = 3
                        },
                        new
                        {
                            Id = 11,
                            ItemName = "Strawberries",
                            Quantity = 1,
                            TripId = 3
                        },
                        new
                        {
                            Id = 12,
                            ItemName = "Cocoa Pebbles",
                            Quantity = 1,
                            TripId = 3
                        },
                        new
                        {
                            Id = 13,
                            ItemName = "Cranberry Juice",
                            Quantity = 1,
                            TripId = 4
                        },
                        new
                        {
                            Id = 14,
                            ItemName = "Mountain Dew",
                            Quantity = 1,
                            TripId = 4
                        },
                        new
                        {
                            Id = 15,
                            ItemName = "Diet Pepesi",
                            Quantity = 4,
                            TripId = 4
                        },
                        new
                        {
                            Id = 16,
                            ItemName = "Lucky Charms",
                            Quantity = 2,
                            TripId = 5
                        },
                        new
                        {
                            Id = 17,
                            ItemName = "Honey Smacks",
                            Quantity = 2,
                            TripId = 5
                        },
                        new
                        {
                            Id = 18,
                            ItemName = "Oat Milk",
                            Quantity = 1,
                            TripId = 5
                        },
                        new
                        {
                            Id = 19,
                            ItemName = "Grapes",
                            Quantity = 2,
                            TripId = 6
                        },
                        new
                        {
                            Id = 20,
                            ItemName = "Cherries",
                            Quantity = 2,
                            TripId = 6
                        },
                        new
                        {
                            Id = 21,
                            ItemName = "Mountain Dew",
                            Quantity = 2,
                            TripId = 6
                        },
                        new
                        {
                            Id = 22,
                            ItemName = "Prezels",
                            Quantity = 1,
                            TripId = 7
                        },
                        new
                        {
                            Id = 23,
                            ItemName = "Honey Roasted Peanuts",
                            Quantity = 1,
                            TripId = 7
                        },
                        new
                        {
                            Id = 24,
                            ItemName = "Water",
                            Quantity = 1,
                            TripId = 7
                        },
                        new
                        {
                            Id = 25,
                            ItemName = "Apple Juice",
                            Quantity = 2,
                            TripId = 8
                        },
                        new
                        {
                            Id = 26,
                            ItemName = "Break",
                            Quantity = 2,
                            TripId = 8
                        },
                        new
                        {
                            Id = 27,
                            ItemName = "Grapes",
                            Quantity = 1,
                            TripId = 8
                        },
                        new
                        {
                            Id = 28,
                            ItemName = "Bread",
                            Quantity = 2,
                            TripId = 9
                        },
                        new
                        {
                            Id = 29,
                            ItemName = "Hot Dogs",
                            Quantity = 2,
                            TripId = 9
                        },
                        new
                        {
                            Id = 30,
                            ItemName = "Ground Beef",
                            Quantity = 1,
                            TripId = 9
                        });
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TripDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            TripDate = new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 1,
                            TripDate = new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 1,
                            TripDate = new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CustomerId = 2,
                            TripDate = new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CustomerId = 2,
                            TripDate = new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CustomerId = 3,
                            TripDate = new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CustomerId = 3,
                            TripDate = new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CustomerId = 4,
                            TripDate = new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CustomerId = 4,
                            TripDate = new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Product", b =>
                {
                    b.HasOne("GroceryStoreAPI.Data.Trip", "Trip")
                        .WithMany("Products")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Trip", b =>
                {
                    b.HasOne("GroceryStoreAPI.Data.Customer", "Customer")
                        .WithMany("Trips")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Customer", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("GroceryStoreAPI.Data.Trip", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
