using System;
using System.Linq;

class Program
{
    static Random rnd = new Random();

    private static void FindMaxAtArray(int[] array, ref int index)
    {
        int max = array[index];
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        index = max;
    }
    public static void QuickSort(int[] array, int left, int right)
    {
        int i = left, j = right;
        int temp = array[(left + right) / 2];

        while (i <= j)
        {
            while (array[i].CompareTo(temp) < 0)
            {
                i++;
            }
            while (array[j].CompareTo(temp) > 0)
            {
                j--;
            }
            if (i <= j)
            {
                int tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
                i++;
                j--;
            }
        }
        if (left < j)
        {
            QuickSort(array, left, j);
        }
        if (i < right)
        {
            QuickSort(array, i, right);
        }
    }
    static void Main(string[] args)
    {
        int index = 5; // first index = from index
        int[] array = new int[20];
        //generating 20 random numbers from 1 to 100 and return the max element (the index get the max element via reference)
        for (int i = 0; i < 20; i++)
        {
            array[i] = rnd.Next(101);
        }
        FindMaxAtArray(array,ref index);
        Console.WriteLine("Max = {0}",index); //max from range 
        //ascending sort
        Console.WriteLine("Ascending order");
        QuickSort(array,0,array.Length-1);
        Console.WriteLine(String.Join("\n",array));
        //descending order
        Console.WriteLine("Descending order");
        Array.Reverse(array);
        Console.WriteLine(String.Join("\n", array));
    } 
}
