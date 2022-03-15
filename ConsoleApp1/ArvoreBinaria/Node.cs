namespace Arvore
{
    public class Node
    {
        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }
        public Node? Father { get; set; }
        public bool RootTree { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        public Node(string name, bool root)
        {
            Name = name;
            RootTree = root;
        }

        public void InsertSon(Node son)
        {
            son.Level = Level + 1;
     
            if (LeftNode == null)
            {
                LeftNode = son;

            }
            else
            {
                RightNode = son;

            }
        }
    }
}