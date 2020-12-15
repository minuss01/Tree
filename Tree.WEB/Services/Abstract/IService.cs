using Tree.WEB.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tree.WEB.Services.Abstract
{
    public interface IService
    {
        Task<CompositeViewModel> GetCompositeByIdAsync(int id);
        Task<LeafViewModel> GetLeafByIdAsync(int id);
        Task<List<CompositeViewModel>> GetAllCompositesAsync();
        Task<List<LeafViewModel>> GetAllLavesAsync();

    }
}