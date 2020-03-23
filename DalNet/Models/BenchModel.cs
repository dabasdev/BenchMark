using System.Data.Entity;

namespace DalNet.Models
{
    public partial class BenchModel : DbContext
    {
        public BenchModel()
            : base("name=BenchDbContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.BasicSalary)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Employee>()
                .Property(e => e.CivilSalary)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Employee>()
                .Property(e => e.OpeningNis)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Employee>()
                .Property(e => e.OpeningUsd)
                .HasPrecision(8, 2);
        }
    }
}
