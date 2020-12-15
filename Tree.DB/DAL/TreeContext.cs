using Tree.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tree.DB.DAL
{
    public class TreeContext : DbContext
    {
        public DbSet<Composite> Composities { get; set; }
        public DbSet<Leaf> Leaves { get; set; }

        public TreeContext(DbContextOptions options) : base(options) { }
        
    }
}
