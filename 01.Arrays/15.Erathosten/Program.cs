using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var currentIter = 1;
        int maxRange = 10000000;
        List<int> pc = Enumerable.Range(2, maxRange).ToList();

        while (currentIter <= Math.Sqrt(maxRange))
        {
            int cur1 = currentIter;
            int cur2 = pc.First(i => i > cur1);
            pc.RemoveAll(i => i != cur2 && i % cur2 == 0);
            currentIter = cur2;
        }

        int[] arr = pc.ToArray();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

