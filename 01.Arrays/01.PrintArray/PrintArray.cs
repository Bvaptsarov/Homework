using System;
using System.Threading;
using System.Threading.Tasks;

class PrintArray
{
    static void Main(string[] args)
    {
        int[] arr = new int[20];
        Parallel.For(0, 20, index => arr[index] = index*5);
        Console.WriteLine(string.Join("\n", arr));
    }
}

