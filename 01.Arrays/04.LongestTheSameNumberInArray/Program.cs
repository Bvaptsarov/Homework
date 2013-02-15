using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 1, 1, 1, 5, 2, 3, 2, 2, 2, 1, 1, 1, 2, 4, 3, 2, 2, 2, 2, 2, 1, 1, 1, 3, 3, 3, 4, 3, 3 };
        int max = 0, number = 0, temp = 0, tempNumber = 0;
        int[] arr_1 = new int[arr.Length + 1];
        Array.Copy(arr, arr_1, arr.Length);
        for (int i = 1; i < arr_1.Length; i++)
        {
            if (arr_1[i] == arr_1[i - 1]) { temp++; tempNumber = arr_1[i]; }
            else if (temp >= max) { number = tempNumber; max = temp; temp = 0; }
            else { temp = 0; }

        }
        Console.WriteLine("{0}-{1}", number, max + 1);
    }
}

