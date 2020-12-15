using Tree.DB.DAL;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Tree.DB.Repositories.Concrete
{
    public class CompositeRepository : ICompositeRepository
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
            return await _context.Composities.Where(c => c.CompositeParentId == null).ToListAsync();
        }

        public async Task<Composite> GetByIdAsync(int id)
        {
            return await _context.Composities.FirstOrDefaultAsync(c => c.Id == id);
        }

        public IQueryable<Composite> GetQueryable()
        {
            return _context.Composities;
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
