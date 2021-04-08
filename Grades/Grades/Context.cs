using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Grades
{
     public class Context : DbContext
    {
        public Context() : base("Grades.Properties.Settings.DBConnectionString") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<CheckPoint> CheckPoints { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Position> Positions { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}