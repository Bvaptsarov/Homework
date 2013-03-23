using System;

namespace BST
{
    [Serializable]
    public class Node
    {
        public int? Value;
        public Node left, right;

        public Node(int data)
        {
            this.Value = data;
            left = null;
            right = null;
        }
    }
}