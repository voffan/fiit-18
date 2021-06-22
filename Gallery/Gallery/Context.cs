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
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Painting> Paintings { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Sell> Sells { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Exhibition> Exhibitions { get; set; }
        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<SellPainting> SellPaintings{ get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
