using Tree.DB.DAL;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tree.DB.Repositories.Concrete
{
    internal class CompositeRepository : ICompositeRepository
    {
        private readonly TreeContext _context;

        public CompositeRepository(TreeContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Composite composite)
        {
            await _context.Composities.AddAsync(composite);
        }

        public async Task<IList<Composite>> GetAllAsync()
        {
            return await _context.Composities.ToListAsync();
        }

        public async Task<Composite> GetByIdAsync(int id)
        {
            return await _context.Composities.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task RemoveAsync(Composite composite)
        {
            await Task.FromResult(_context.Composities.Remove(composite));
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Composite composite)
        {
            await Task.FromResult(_context.Composities.Update(composite));
        }
    }
}
