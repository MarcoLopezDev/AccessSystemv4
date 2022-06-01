using AccessSystemv4.Models;
using Microsoft.EntityFrameworkCore;

namespace AccessSystemv4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Trabajador> Trabajador { get; set; }
    }
}
