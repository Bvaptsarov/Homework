using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        int n, k;
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        if (k > array[n-1]) Console.WriteLine(array[array.Length-1]);
        else if (k < array[0]) Console.WriteLine("Such an element does not exist!");
        else
        {
            int index = Array.BinarySearch(array, k);
            if (index > 0)
            {
                Console.WriteLine(array[index-1]);
            }
            else if (index == 0) Console.WriteLine("There is no element <=k beside the element K!");
            else
            {
                Console.WriteLine(array[(index*(-1))-2]);
            }
        }
    }
}

