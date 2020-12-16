using Tree.DB.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Tree.DB.Repositories.Abstract
{
    public interface INodeRepository
    {
        IQueryable<Node> GetQueryable();
        Task<IList<Node>> GetAllAsync();
        Task<Node> GetByIdAsync(int id);
        Task AddAsync(Node node);
        Task RemoveAsync(Node node);
        Task UpdateAsync(Node node);
        Task SaveChangesAsync();
    }
}
