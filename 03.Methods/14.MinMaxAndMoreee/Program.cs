using System;
using System.Numerics;
/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
*/
class Program
{
    static Random rnd = new Random();
    static void Minimum(int[] arr)
    {
        QuickSort(arr,0,arr.Length-1);
        Console.WriteLine("Maximum = {0}",arr[0]);
    }

    static void Maximum(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine("Maximum = {0}",arr[arr.Length-1]);
    }

    static void Average(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Average = {0}",(double)(sum/arr.Length));
    }

    static void Summary(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("Sum = {0}",sum);
    }

    private static void Product(int[] arr)
    {
        BigInteger big = new BigInteger();
        big = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            big *= arr[i];
        }
        Console.WriteLine("Product = {0}",big);
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
        int[] arr = new int[50];
        for (int i = 0; i < 50; i++)
        {
            arr[i] = rnd.Next(1, 101);
        }
        Minimum(arr); //find the minimum value
        Maximum(arr); // find the maximum value;
        Average(arr);// print the average value (sums all values and divide them by the length of the array)
        Summary(arr); //print the sum of the array
        Product(arr);
    }
}
