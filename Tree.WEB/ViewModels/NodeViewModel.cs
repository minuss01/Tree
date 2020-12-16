using System.Collections.Generic;

namespace Tree.WEB.ViewModels
{
    public class NodeViewModel : AbstractViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<NodeViewModel> Nodes { get; set; }
    }
}
