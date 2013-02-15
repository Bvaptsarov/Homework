using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 0, 0, 0, 0, 0, 0 };
        int[] checking = new int[0];
        int freqNum = arr[0];

        Array.Sort(arr);

        if (arr[arr.Length - 1] < arr.Length)
        {
            checking = new int[arr.Length];
        }
        else if (arr[arr.Length - 1] > arr.Length)
        {
            checking = new int[arr[arr.Length - 1] + 1];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            checking[arr[i]]++;
        }

        for (int i = 0; i < checking.Length; i++)
        {
            if (freqNum < checking[i]) freqNum = checking[i];
            if (checking[i] != 0) Console.WriteLine("{0} - {1}", i, checking[i]);
        }

        Console.WriteLine("The most frequent number is : {1}, appeared {0} times.", freqNum, Array.IndexOf(checking, freqNum));
    }
}

