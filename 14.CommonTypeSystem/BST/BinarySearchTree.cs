using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//Missing IEnumerable and DeleteElement working incorrect, you can take points for the task, 
//-- however there is ToString using Traverse method, to traverse the tree
//deep cloning working correctly

namespace BST
{ 
    [Serializable]
    public class BinarySearchTree : ICloneable
    {
        StringBuilder toStringTemp = new StringBuilder();

        public Node CurrentParrent { get; private set; }

        public Node FirstParrent { get; private set; }

        byte curr = 0;

        public BinarySearchTree()
        {
            CurrentParrent = null;
        }

        public Node AddElement(int ele)
        {
            Node newNode = new Node(ele);
            curr++;
            if (curr == 1)
                FirstParrent = newNode;
            curr = 2;

            if (CurrentParrent == null)
            {
                CurrentParrent = newNode;
            }
            return newNode;
        }

        public void InsertElement(Node root, Node newNode)
        {
            if (newNode.Value < root.Value)
            {
                if (root.left == null)
                {
                    root.left = newNode;
                }
                else
                {
                    root = root.left;
                    InsertElement(root, newNode);
                }
            }
            else if (newNode.Value > root.Value)
            {
                if (root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    root = root.right;
                    InsertElement(root, newNode);
                }
            }
        }

        //simple delete without rearanging the tree, working incorrectly, take points from the task
        public void DeleteElement(int ele, Node root)
        {
            if (root == null)
                return;

            DeleteElement(ele, root.left);

            if (root.Value == ele)
            {
                root.Value = null;
            }

            DeleteElement(ele, root.right);
        }

        public override string ToString()
        {
            Traverse(FirstParrent);
            return toStringTemp.ToString();
        }

        private void Traverse(Node curr)
        {
            if (curr == null)
                return;
            Traverse(curr.left);
            toStringTemp.Append(curr.Value + " ");
            Traverse(curr.right);
        }

        public override bool Equals(object obj)
        {
            BinarySearchTree other = obj as BinarySearchTree;
            if (other == null)
                return false;
            return IsEquals(CurrentParrent, other.CurrentParrent);
        }

        private bool IsEquals(Node first, Node second) //stollen from vic-alexiev... i'm such a terrible person
        {
            if (first == null && second == null)
            {
                return true;
            }
            else if (first != null && second != null)
            {
                return first == second && IsEquals(first.left, second.left) && IsEquals(first.right, second.right);
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(BinarySearchTree first, BinarySearchTree second)
        {
            return BinarySearchTree.Equals(first, second);
        }

        public static bool operator !=(BinarySearchTree first, BinarySearchTree second)
        {
            return !(BinarySearchTree.Equals(first, second));
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((toStringTemp != null) ? this.toStringTemp.GetHashCode() : 0);
                result = result * 23 + ((CurrentParrent != null) ? this.CurrentParrent.GetHashCode() : 0);
                result = result * 23 + ((FirstParrent != null) ? this.FirstParrent.GetHashCode() : 0);
                result = result * 23 + this.curr.GetHashCode();
                return result;
            }
        }

        public object Clone()
        {
            return DeepClone<BinarySearchTree>(this);
        }

        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}