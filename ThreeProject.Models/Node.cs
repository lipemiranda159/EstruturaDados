namespace ThreeProject.Models
{
    public class Node
    {
        public int Key { get; set; }
        public ThreeProject.Models.Node LeftNode { get; set; }
        public ThreeProject.Models.Node RightNode { get; set; }

        public Node(int key)
        {
            Key = key;
            LeftNode = null;
            RightNode = null;
        }
    }
}
