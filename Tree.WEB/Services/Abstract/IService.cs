using Tree.WEB.ViewModels;
using System.Threading.Tasks;

namespace Tree.WEB.Services.Abstract
{
    public interface IService
    {
        public Task<CompositeViewModel> GetByIdAsync(int id);
    }
}