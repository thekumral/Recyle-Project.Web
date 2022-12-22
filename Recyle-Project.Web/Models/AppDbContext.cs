using Microsoft.EntityFrameworkCore;

namespace Recyle_Project.Web.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<coinCollectionPoint> coinCollectionPoints{ get; set; }
        public DbSet<recyleObjects> recyleObjects { get; set; }

        public DbSet<user> users { get; set; }
        public DbSet<Recyletype> recyletypes { get; set; }
    }
}
