using Microsoft.EntityFrameworkCore;

namespace CarDealer.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext( DbContextOptions<AppDBContext> options
            ):base(options)
        {
        }
        public DbSet<Car> Cars  { get; set; }

    }
}
