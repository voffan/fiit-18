using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Gallery
{
    public class Context : DbContext
    {
        public Context() : base("DB") { }
        public DbSet<Person> People { get; set; }
        public DbSet<Painting> Paintings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Auth> Auths { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
