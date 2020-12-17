using Tree.WEB.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tree.WEB.Services.Abstract
{
    public interface IService
    {
        Task<NodeViewModel> GetNodeByIdAsync(int id);
        Task<List<NodeViewModel>> GetAllNodesAsync();
        Task<List<LabelValueViewModel>> GetSelectValuesAsync();
        Task<NodeViewModel> AddNodeAsync(NodeAddFormViewModel request);
        Task<NodeViewModel> UpdateNodeAsync(NodePostFormViewModel request);
        Task<NodeViewModel> RemoveNodeAsync(int id);

    }
}