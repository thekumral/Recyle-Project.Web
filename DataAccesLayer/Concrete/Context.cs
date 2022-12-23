using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
     public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=ReProject;Port=5432;User Id=postgres;Password=Mk7161**");
        }
        public DbSet<CoinCollectionPoint> coinCollectionPoints { get; set; }
        public DbSet<RecyleObjects> recyleObjects { get; set; }

        public DbSet<User> users { get; set; }
        public DbSet<RecyleTypes> recyletypes { get; set; }
    }
}
