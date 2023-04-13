using Microsoft.EntityFrameworkCore;
using Pustok_Start.Models;

namespace Pustok_Start.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext>options):base(options) 
        {

        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
