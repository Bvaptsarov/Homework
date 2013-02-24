using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestGenericList
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            list.AddElement(10);
            list.AddElement(5);
            list.AddElement(4);
            list.InsertElement(1, 15);
            list.InsertElement(1, 12);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            list[0] = 5;
            int min = list.Min();
            int max = list.Max();
            Console.WriteLine(min);
            Console.WriteLine(max);
            list.Clear();
            Console.WriteLine(list.ToString());
        }
    }
}
