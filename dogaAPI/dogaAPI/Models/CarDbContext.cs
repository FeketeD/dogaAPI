using Microsoft.EntityFrameworkCore;

namespace dogaAPI.Models
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cars> Car { get; set; } = null!;
        public DbSet<Dealership> Dealer { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string conn = "server=192.168.30.16; database=Cars; user=root; password=password";

                optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
            }
        }
    }
}
