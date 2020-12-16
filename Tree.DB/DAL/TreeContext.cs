using Tree.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tree.DB.DAL
{
    public class TreeContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        public TreeContext(DbContextOptions options) : base(options) { }
    }
}
