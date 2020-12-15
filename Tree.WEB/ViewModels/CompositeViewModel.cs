using System.Collections.Generic;

namespace Tree.WEB.ViewModels
{
    public class CompositeViewModel : AbstractViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<LeafViewModel> Leaves { get; set; }
        public List<CompositeViewModel> Composites { get; set; }
    }
}
