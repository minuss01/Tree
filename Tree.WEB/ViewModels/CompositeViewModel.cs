using System.Collections.Generic;
using Tree.DB.Enums;

namespace Tree.WEB.ViewModels
{
    public class CompositeViewModel : AbstractViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeTypeEnum Type { get; set; }

        public List<LeafViewModel> Leaves { get; set; }
        public List<CompositeViewModel> Composites { get; set; }
    }
}
