using Front_to_back_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_to_back_2
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Service>Services { get; set; }

    }
}
