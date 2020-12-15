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
        private readonly ICompositeRepository _compositeRepository;
        private readonly ILeafRepository _leafRepository;
        private readonly IMapper _mapper;

        public Service(
            ICompositeRepository compositeRepository,
            ILeafRepository leafRepository,
            IMapper mapper)
        {
            _compositeRepository = compositeRepository;
            _leafRepository = leafRepository;
            _mapper = mapper;
        }
        public async Task<CompositeViewModel> GetCompositeByIdAsync(int id)
        {
            Composite composite = await _compositeRepository.GetByIdAsync(id);
            CompositeViewModel model = _mapper.Map<CompositeViewModel>(composite);
            return model;
        }

        public async Task<List<CompositeViewModel>> GetAllCompositesAsync()
        {
            IList<Composite> composites = await _compositeRepository.GetAllAsync();
            List<CompositeViewModel> models = _mapper.Map<List<CompositeViewModel>>(composites);
            return models;
        }

        public async Task<LeafViewModel> GetLeafByIdAsync(int id)
        {
            Leaf leaf = await _leafRepository.GetByIdAsync(id);
            LeafViewModel model = _mapper.Map<LeafViewModel>(leaf);
            return model;
        }

        public async Task<List<LeafViewModel>> GetAllLavesAsync()
        {
            IList<Leaf> leaves = await _leafRepository.GetAllAsync();
            List<LeafViewModel> models = _mapper.Map<List<LeafViewModel>>(leaves);
            return models;
        }
    }
}
