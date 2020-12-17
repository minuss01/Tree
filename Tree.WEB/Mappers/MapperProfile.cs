using AutoMapper;
using Tree.DB.Entities;
using Tree.WEB.ViewModels;

namespace Tree.WEB.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Node, NodeViewModel>();
            CreateMap<NodeViewModel, NodePostFormViewModel>();
            CreateMap<NodePostFormViewModel, Node>();
            CreateMap<Node, LabelValueViewModel>()
                .ForMember(l => l.Label, opt => opt.MapFrom(n => n.Name))
                .ForMember(l => l.Value, opt => opt.MapFrom(n => n.Id));
        }
    }
}
