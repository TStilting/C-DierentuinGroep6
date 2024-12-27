using DierentuinGroep6.Models;
using System.Collections.Generic;

namespace DierentuinGroep6.Data
{
    public class ZooContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ZooContext(DbContextOptions<ZooContext> options) : base(options) { }
    }
}
