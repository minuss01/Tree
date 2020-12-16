using Tree.DB.DAL;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Tree.DB.Repositories.Concrete
{
    public class NodeRepository : INodeRepository
    {
        private readonly TreeContext _context;

        public NodeRepository(TreeContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Node node)
        {
            await _context.Nodes.AddAsync(node);
        }

        public async Task<IList<Node>> GetAllAsync()
        {
            return await _context.Nodes.Where(c => c.NodeParentId == null).ToListAsync();
        }

        public async Task<Node> GetByIdAsync(int id)
        {
            return await _context.Nodes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public IQueryable<Node> GetQueryable()
        {
            return _context.Nodes;
        }

        public async Task RemoveAsync(Node node)
        {
            await Task.FromResult(_context.Nodes.Remove(node));
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Node node)
        {
            await Task.FromResult(_context.Nodes.Update(node));
        }
    }
}
