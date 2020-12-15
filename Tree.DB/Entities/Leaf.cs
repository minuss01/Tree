using Tree.DB.Enums;

namespace Tree.DB.Entities
{
    public class Leaf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeTypeEnum Type { get; set; }


        public int CompositeParentId { get; set; }
        public virtual Composite CompositeParent { get; set; }

        protected Leaf() { Type = NodeTypeEnum.LEAF; }

        public Leaf(string name) 
        { 
            Name = name;
            Type = NodeTypeEnum.LEAF;
        }
    }
}
