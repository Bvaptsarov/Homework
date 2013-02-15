using System;

class Program
{

    public static void QuickSort(String[] array, int left, int right)
    {
        int i = left, j = right;
        String temp = array[(left + right) / 2];

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
                String tmp = array[i];
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
        String[] arr = { "gy", "bo", "tro", "mo", "fO", "12321321", "13213213214212","B","A", "C","W","O" };
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine(String.Join(" ",arr));
    }
}

