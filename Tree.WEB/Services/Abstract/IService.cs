using Tree.WEB.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tree.WEB.Services.Abstract
{
    public interface IService
    {
        Task<NodeViewModel> GetNodeByIdAsync(int id);
        Task<List<NodeViewModel>> GetAllNodesAsync();

    }
}