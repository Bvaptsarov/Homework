using System;
using System.Linq;

namespace BST
{
    class TestBST
    {
        static void Main(string[] args)
        {
            BinarySearchTree test = new BinarySearchTree();

            Node elderRoot = test.AddElement(5);
            
                test.InsertElement(test.CurrentParrent, elderRoot);
                test.InsertElement(test.CurrentParrent, test.AddElement(6));
                test.InsertElement(test.CurrentParrent, test.AddElement(10));
                test.InsertElement(test.CurrentParrent, test.AddElement(1));
                test.InsertElement(test.CurrentParrent, test.AddElement(15));
                test.InsertElement(test.CurrentParrent, test.AddElement(2));
                test.InsertElement(test.CurrentParrent, test.AddElement(3));
                test.InsertElement(test.CurrentParrent, test.AddElement(12321));
                test.InsertElement(test.CurrentParrent, test.AddElement(61));
                test.InsertElement(test.CurrentParrent, test.AddElement(90));
                test.InsertElement(test.CurrentParrent, test.AddElement(0));
                test.InsertElement(test.CurrentParrent, test.AddElement(-5));
                test.InsertElement(test.CurrentParrent, test.AddElement(-123));
            
            BinarySearchTree ff = (BinarySearchTree)test.Clone();
            Console.WriteLine(ff);
        }
    }
}
