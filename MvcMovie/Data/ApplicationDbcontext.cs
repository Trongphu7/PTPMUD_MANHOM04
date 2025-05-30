using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<HeThongPhanPhoi> HeThongPhanPhois { get; set; }
        public DbSet<DaiLy> DaiLys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaiLy>()
                .HasOne(d => d.HeThongPhanPhoi)
                .WithMany()
                .HasForeignKey(d => d.MaHTPP);
        }
    }
}