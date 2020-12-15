using Tree.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tree.DB.Repositories.Abstract
{
    public interface ILeafRepository : IRepository
    {
        Task<IList<Leaf>> GetAllAsync();
        Task<Leaf> GetByIdAsync(int id);
        Task AddAsync(Leaf leaf);
        Task RemoveAsync(Leaf leaf);
        Task UpdateAsync(Leaf leaf);
        Task SaveChangesAsync();
    }
}
