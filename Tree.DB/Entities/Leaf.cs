namespace Tree.DB.Entities
{
    public class Leaf
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompositeParentId { get; set; }
        public virtual Composite CompositeParent { get; set; }
    }
}
