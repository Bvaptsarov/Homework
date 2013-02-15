using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder str = new StringBuilder();
        StringBuilder str_2 = new StringBuilder();
        int[] arr = { 1, 2, 1, 2, 3, 4, 2, 5, 6, 7, 8, 10, 2, 3, 4, 5, 6, 7, 8, 123, 123 };
        int max = 0, temp = 0;
        int[] arr_1 = new int[arr.Length + 1];
        Array.Copy(arr, arr_1, arr.Length);

        for (int i = 1; i < arr_1.Length; i++)
        {
            if (arr_1[i] >= arr_1[i - 1]) { str.Append(arr_1[i - 1] + " "); temp++; }
            else if (temp > max)
            {
                str.Append(arr_1[i - 1]);
                str_2.Clear();
                max = temp;
                string s = str.ToString();
                str_2.Append(s);
                str.Clear();
                temp = 0;
            }
            else continue;
        }
        Console.WriteLine(str_2.ToString());
    }
}
