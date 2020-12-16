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
            NodeViewModel model = _mapper.Map<NodeViewModel>(node);
            return model;
        }

        public async Task<List<NodeViewModel>> GetAllNodesAsync()
        {
            IList<Node> nodes = await _nodeRepository.GetAllAsync();
            List<NodeViewModel> models = _mapper.Map<List<NodeViewModel>>(nodes);
            return models;
        }
    }
}
