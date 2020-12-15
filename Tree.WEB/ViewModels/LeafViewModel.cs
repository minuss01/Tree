using Tree.DB.Enums;

namespace Tree.WEB.ViewModels
{
    public class LeafViewModel : AbstractViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeTypeEnum Type { get; set; }

    }
}
