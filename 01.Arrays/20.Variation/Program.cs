using System;
using System.Text;

class Program
{
    static int[] array;
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        array = new int[k];
        RecursiveVariationCall(array, n, 0,k);
        Array.Clear(array, 0, k);
    }

    private static void RecursiveVariationCall(int[] intArray, int n,int step,int k)
    {
        if (step == k )
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                intArray[step] = i;
                RecursiveVariationCall(intArray,n,step+1,k);
            }
        }
    }
}

