using Microsoft.EntityFrameworkCore;
using System;

namespace GroceryStoreAPI.Data
{
    public class GrocertyStoreContext : DbContext
    {
        public GrocertyStoreContext(DbContextOptions<GrocertyStoreContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


                modelBuilder.Entity<Customer>(entity =>
                {
                    // As needed changes to the database from the fluent api method
                });

                modelBuilder.Entity<Trip>(entity =>
                {
                    // As needed changes to the database from the fluent api method
                });

                modelBuilder.Entity<Product>(entity =>
                {
                    // As needed changes to the database from the fluent api method
                });

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, FirstName = "Joe", LastName = "Biden", DateOfBirth = DateTime.Parse("1942-11-20"), },
                new Customer { Id = 2, FirstName = "Donald", LastName = "Trump", DateOfBirth = DateTime.Parse("1946-06-14"), },
                new Customer { Id = 3, FirstName = "Barack", LastName = "Obama", DateOfBirth = DateTime.Parse("1961-08-04"), },
                new Customer { Id = 4, FirstName = "George", LastName = "Bush", DateOfBirth = DateTime.Parse("1946-07-06"), }
                );

            modelBuilder.Entity<Trip>().HasData(
                new Trip { Id = 1, CustomerId = 1, TripDate = DateTime.Parse("2021-05-20") },
                new Trip { Id = 2, CustomerId = 1, TripDate = DateTime.Parse("2021-05-24") },
                new Trip { Id = 3, CustomerId = 1, TripDate = DateTime.Parse("2021-05-28") },
                new Trip { Id = 4, CustomerId = 2, TripDate = DateTime.Parse("2021-06-01") },
                new Trip { Id = 5, CustomerId = 2, TripDate = DateTime.Parse("2021-06-22") },
                new Trip { Id = 6, CustomerId = 3, TripDate = DateTime.Parse("2021-01-20") },
                new Trip { Id = 7, CustomerId = 3, TripDate = DateTime.Parse("2021-02-22") },
                new Trip { Id = 8, CustomerId = 4, TripDate = DateTime.Parse("2021-03-18") },
                new Trip { Id = 9, CustomerId = 4, TripDate = DateTime.Parse("2021-04-21") }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ItemName = "Apple", TripId = 1, Quantity=1 },
                new Product { Id = 2, ItemName = "Milk", TripId = 1, Quantity = 1 },
                new Product { Id = 3, ItemName = "Fruity Pebbles", TripId = 1, Quantity = 1 },
                new Product { Id = 4, ItemName = "Oatmeal", TripId = 1, Quantity = 2 },

                new Product { Id = 5, ItemName = "Bread", TripId = 2, Quantity = 1 },
                new Product { Id = 6, ItemName = "Bagels", TripId = 2, Quantity = 1 },
                new Product { Id = 7, ItemName = "Out Milk", TripId = 2, Quantity = 3 },
                new Product { Id = 8, ItemName = "Apple Juice", TripId = 2, Quantity = 1 },

                new Product { Id = 9, ItemName = "Orange Juice", TripId = 3, Quantity = 1 },
                new Product { Id = 10, ItemName = "Grapes", TripId = 3, Quantity = 1 },
                new Product { Id = 11, ItemName = "Strawberries", TripId = 3, Quantity = 1 },
                new Product { Id = 12, ItemName = "Cocoa Pebbles", TripId = 3, Quantity = 1 },

                new Product { Id = 13, ItemName = "Cranberry Juice", TripId = 4, Quantity = 1 },
                new Product { Id = 14, ItemName = "Mountain Dew", TripId = 4, Quantity = 1 },
                new Product { Id = 15, ItemName = "Diet Pepesi", TripId = 4, Quantity = 4 },

                new Product { Id = 16, ItemName = "Lucky Charms", TripId = 5, Quantity = 2 },
                new Product { Id = 17, ItemName = "Honey Smacks", TripId = 5, Quantity = 2 },
                new Product { Id = 18, ItemName = "Oat Milk", TripId = 5, Quantity = 1 },

                new Product { Id = 19, ItemName = "Grapes", TripId = 6, Quantity = 2 },
                new Product { Id = 20, ItemName = "Cherries", TripId = 6, Quantity = 2 },
                new Product { Id = 21, ItemName = "Mountain Dew", TripId = 6, Quantity = 2 },

                new Product { Id = 22, ItemName = "Prezels", TripId = 7, Quantity = 1 },
                new Product { Id = 23, ItemName = "Honey Roasted Peanuts", TripId = 7, Quantity = 1 },
                new Product { Id = 24, ItemName = "Water", TripId = 7, Quantity = 1 },

                new Product { Id = 25, ItemName = "Apple Juice", TripId = 8, Quantity = 2 },
                new Product { Id = 26, ItemName = "Break", TripId = 8, Quantity = 2 },
                new Product { Id = 27, ItemName = "Grapes", TripId = 8, Quantity = 1 },

                new Product { Id = 28, ItemName = "Bread", TripId = 9, Quantity = 2 },
                new Product { Id = 29, ItemName = "Hot Dogs", TripId = 9, Quantity = 2 },
                new Product { Id = 30, ItemName = "Ground Beef", TripId = 9, Quantity = 1 }
                );

        }

    }


}