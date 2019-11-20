using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApi.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace RestaurantApi.Infrastructure.Data // CS321_W3D1_RestaurantAPI.Data
{
    public class RestaurantContext : IdentityDbContext
    {// TODO: implement a DbSet<Restaurant> property
        public DbSet<Restaurant> Restaurants { get; set; }

        // This method runs once when the DbContext is first used.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // TODO: use optionsBuilder to configure a Sqlite db
            optionsBuilder.UseSqlite("Data Source=Restaurants.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the Restaurants table

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant { Id = 1, Name = "Great Tacos", Owner = "Bob Martinez", Type = "Mexican" },
                new Restaurant { Id = 2, Name = "Delicious Thai Meals", Owner = "Michael Khan", Type = "Thai" },
                new Restaurant { Id = 3, Name = "South Asian Treats", Owner = "Raj Biswanathan", Type = "Indian" }


                );


        }

    }
}