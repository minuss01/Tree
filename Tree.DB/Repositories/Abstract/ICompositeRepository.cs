using Tree.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tree.DB.Repositories.Abstract
{
    public interface ICompositeRepository : IRepository
    {
        Task<IList<Composite>> GetAllAsync();
        Task<Composite> GetByIdAsync(int id);
        Task AddAsync(Composite composite);
        Task RemoveAsync(Composite composite);
        Task UpdateAsync(Composite composite);
        Task SaveChangesAsync();
    }
}
