using Tree.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace Tree.DB.DAL
{
    public class TreeContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        public TreeContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Node>().HasData(new Node { Id = 1, Name = "Node1", NodeParentId = null});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 2, Name = "Node2", NodeParentId = 1});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 3, Name = "Node3", NodeParentId = 1});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 4, Name = "Node4", NodeParentId = 1});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 5, Name = "Node5", NodeParentId = null});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 6, Name = "Node6", NodeParentId = 5});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 7, Name = "Node7", NodeParentId = 5});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 8, Name = "Node8", NodeParentId = 2});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 9, Name = "Node9", NodeParentId = 8});
            modelBuilder.Entity<Node>().HasData(new Node { Id = 10, Name = "Node10", NodeParentId = 6});
        }
    }
}
