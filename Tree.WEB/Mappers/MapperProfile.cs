using AutoMapper;
using Tree.DB.Entities;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Composite, CompositeViewModel>().ReverseMap();
            CreateMap<Leaf, LeafViewModel>().ReverseMap();
        }
    }
}
