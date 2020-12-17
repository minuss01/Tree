using System.Collections.Generic;

namespace Tree.DB.Entities
{
    public class Node
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Node> Nodes { get; set; }

        public int? NodeParentId { get; set; }
        public virtual Node NodeParent { get; set; }

        public Node() { }

        public Node(
            string name,
            int? nodeParentId)
        { 
            Name = name;
            NodeParentId = nodeParentId;
        }

        public void AddNode(Node node)
        {
            Nodes.Add(node);
        }

    }
}
