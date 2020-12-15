using System.Collections.Generic;

namespace Tree.DB.Entities
{
    public class Composite
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Composite> Composites { get; set; }
        public virtual List<Leaf> Leaves { get; set; }

        public int? CompositeParentId { get; set; }
        public virtual Composite CompositeParent { get; set; }


        public Composite(string name) { Name = name; }

        public void AddComposite(Composite composite)
        {
            Composites.Add(composite);
        }

    }
}
