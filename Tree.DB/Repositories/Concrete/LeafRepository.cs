using Tree.DB.DAL;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tree.DB.Repositories.Concrete
{
    internal class LeafRepository : ILeafRepository
    {
        private readonly TreeContext _context;

        public LeafRepository(TreeContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Leaf leaf)
        {
            await _context.Leaves.AddAsync(leaf);
        }

        public async Task<IList<Leaf>> GetAllAsync()
        {
            return await _context.Leaves.ToListAsync();
        }

        public async Task<Leaf> GetByIdAsync(int id)
        {
            return await _context.Leaves.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task RemoveAsync(Leaf leaf)
        {
            await Task.FromResult(_context.Leaves.Remove(leaf));
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Leaf leaf)
        {
            await Task.FromResult(_context.Leaves.Update(leaf));
        }
    }
}
