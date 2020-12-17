using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tree.DB.Entities;
using Tree.DB.Repositories.Abstract;
using Tree.WEB.Services.Abstract;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Services.Concrete
{
    public class Service : IService
    {
        private readonly INodeRepository _nodeRepository;
        private readonly IMapper _mapper;

        public Service(
            INodeRepository nodeRepository,
            IMapper mapper)
        {
            _nodeRepository = nodeRepository;
            _mapper = mapper;
        }
        public async Task<NodeViewModel> GetNodeByIdAsync(int id)
        {
            Node node = await _nodeRepository.GetByIdAsync(id);
            if (node == null)
            {
                return new NodeViewModel { IsSuccess = false, Message = "The node has not been found." };

            }
            NodeViewModel model = _mapper.Map<NodeViewModel>(node);
            model.IsSuccess = true;
            return model;
        }

        public async Task<List<NodeViewModel>> GetAllNodesAsync()
        {
            IList<Node> nodes = await _nodeRepository.GetAllAsync();
            List<NodeViewModel> models = _mapper.Map<List<NodeViewModel>>(nodes);
            return models;
        }

        public async Task<List<LabelValueViewModel>> GetSelectValuesAsync()
        {
            IList<Node> nodes = await _nodeRepository.GetAllForSelectValuesAsync();
            List<LabelValueViewModel> models = _mapper.Map<List<LabelValueViewModel>>(nodes);
            return models;
        }

        public async Task<NodeViewModel> AddNodeAsync(NodeFormViewModel request)
        {
            Node node = _mapper.Map<Node>(request);

            try
            {
                await _nodeRepository.AddAsync(node);
                await _nodeRepository.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                return new NodeViewModel { IsSuccess = false, Message = "The node has not been added." };
            }

            return new NodeViewModel { IsSuccess = true, Message = "The node has been added." };
        }

        public async Task<NodeViewModel> UpdateNodeAsync(NodeFormViewModel request)
        {
            var node = _mapper.Map<Node>(request);

            try
            {
                await _nodeRepository.UpdateAsync(node);
                await _nodeRepository.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                return new NodeViewModel { IsSuccess = false, Message = "The node has not been updated." };
            }

            return new NodeViewModel { IsSuccess = true, Message = "The node has been updated." };
        }

        public async Task<NodeViewModel> RemoveNodeAsync(int id)
        {
            Node node = await _nodeRepository.GetByIdAsync(id);

            if (node == null)
            {
                return new NodeViewModel { IsSuccess = false, Message = "The node has not been deleted." };
            }
            try
            {
                await _nodeRepository.RemoveAsync(node);
                await _nodeRepository.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                return new NodeViewModel { IsSuccess = false, Message = "The node has not been deleted."};
            }

            return new NodeViewModel { IsSuccess = true, Message = "The node has been deleted." };
        }
        
    }
}
