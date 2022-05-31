using Microsoft.EntityFrameworkCore;
using web_back.Models;

namespace web_back.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Size> Sizes { get; set; }
    }
}
