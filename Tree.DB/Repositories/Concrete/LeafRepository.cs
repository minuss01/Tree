using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tree.DB.DAL;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;

namespace Tree.DB.Repositories.Concrete
{
    public class LeafRepository : ILeafRepository
    {

        private readonly TreeContext _context;

        public LeafRepository(TreeContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Leaf composite)
        {
            await _context.Leaves.AddAsync(composite);
        }

        public async Task<IList<Leaf>> GetAllAsync()
        {
            return await _context.Leaves.ToListAsync();
        }

        public async Task<Leaf> GetByIdAsync(int id)
        {
            return await _context.Leaves.FirstOrDefaultAsync(c => c.Id == id);
        }

        public IQueryable<Leaf> GetQueryable()
        {
            return _context.Leaves;
        }

        public async Task RemoveAsync(Leaf composite)
        {
            await Task.FromResult(_context.Leaves.Remove(composite));
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Leaf composite)
        {
            await Task.FromResult(_context.Leaves.Update(composite));
        }

    }
}
