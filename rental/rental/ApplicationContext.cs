using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace rental
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PositionEmployee> PositionEmployees { get; set; }
        
        public DbSet<Blacklist> Blacklists { get; set; }
        
        public DbSet<Rental> Rentals { get; set; }


        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=dbrental;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>();
            modelBuilder.Entity<Employee>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<Disk>();
            modelBuilder.Entity<Client>();
            modelBuilder.Entity<Country>();
            modelBuilder.Entity<PositionEmployee>();
            modelBuilder.Entity<Blacklist>()
                .HasNoKey();
            modelBuilder.Entity<Rental>()
                .HasNoKey();
        }

    }
}

