using Microsoft.EntityFrameworkCore;
using WebApp.Controllers.Models;

namespace WebApp
{
    public class ApplicarionDbContext: DbContext
    {
        public ApplicarionDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

    }
}
