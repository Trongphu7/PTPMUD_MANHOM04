using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Thêm DbSet cho các model của bạn
        public DbSet<BMIModel> BMIs { get; set; }
    }
}
