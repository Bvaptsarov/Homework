using System;

class Program
{
    static int Counter(int temp, int[] arr)
    {
        int br = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == temp) { br++; }
        }
        return br;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 5, 2, 2, 1, 4, 5, 6, 2, 4, 4, 3 };
        int number = 5;
        Console.WriteLine(Counter(number, arr));
    }
}

