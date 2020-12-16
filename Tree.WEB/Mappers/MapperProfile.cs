using AutoMapper;
using Tree.DB.Entities;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Node, NodeViewModel>().ReverseMap();
        }
    }
}
