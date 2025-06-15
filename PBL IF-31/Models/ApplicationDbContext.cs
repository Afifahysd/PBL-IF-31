using Microsoft.EntityFrameworkCore;

namespace PBL_IF_31.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Divisi> Divisis { get; set; }
    }
}
