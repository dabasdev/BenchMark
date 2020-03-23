using Microsoft.EntityFrameworkCore;

namespace DalCore.Models
{
    public partial class BenchMarkDbContext : DbContext
    {
        public BenchMarkDbContext()
        {
        }

        public BenchMarkDbContext(DbContextOptions<BenchMarkDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=BenchMarkDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BasicSalary).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.BirthOfDate).HasColumnType("date");

                entity.Property(e => e.CivilSalary).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Department).HasMaxLength(20);

                entity.Property(e => e.EducationLevel).HasMaxLength(20);

                entity.Property(e => e.EmployeeCode).HasMaxLength(15);

                entity.Property(e => e.EmployeeName).HasMaxLength(250);

                entity.Property(e => e.EmployeeType).HasMaxLength(5);

                entity.Property(e => e.EmployerJob).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(5);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdNumber).HasMaxLength(9);

                entity.Property(e => e.MaritalStatus).HasMaxLength(10);

                entity.Property(e => e.MobileNumber).HasMaxLength(10);

                entity.Property(e => e.OpeningNis).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OpeningUsd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PhoneNumber).HasMaxLength(10);

                entity.Property(e => e.Speciality).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
