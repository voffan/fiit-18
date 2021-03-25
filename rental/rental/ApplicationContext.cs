using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace rental
{
    public class ApplicationContext : DbContext
    { 
        public ApplicationContext() : base("dbrental") {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PositionEmployee> PositionEmployees { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}

