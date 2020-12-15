using System.Collections.Generic;
using Tree.DB.Enums;

namespace Tree.DB.Entities
{
    public class Composite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NodeTypeEnum Type { get; set; }

        public virtual List<Composite> Composites { get; set; }
        public virtual List<Leaf> Leaves { get; set; }

        public int? CompositeParentId { get; set; }
        public virtual Composite CompositeParent { get; set; }

        protected Composite(){ Type = NodeTypeEnum.COMPOSITE; }
        public Composite(string name) 
        { 
            Name = name;
            Type = NodeTypeEnum.COMPOSITE;
        }

        public void AddComposite(Composite composite)
        {
            Composites.Add(composite);
        }

    }
}
