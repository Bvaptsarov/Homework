using System;

class Program
{
    static void CheckPrevNextE(int pos, int[] arr)
    {
        if (pos == 0)
        {
            if (arr[pos] < arr[pos + 1])
                Console.WriteLine("arr[{2}] = {0} < arr[{3}] = {1}", arr[pos], arr[pos + 1], pos, pos + 1);
            else
                Console.WriteLine("arr[{2}] = {0} > arr[{3}] = {1}", arr[pos], arr[pos + 1], pos, pos + 1);
        }
        else if (pos == arr.Length - 1)
        {
            if (arr[pos] < arr[pos - 1])
                Console.WriteLine("arr[{2}] = {0} < arr[{3}] = {1}", arr[pos], arr[pos - 1], pos, pos - 1);
            else
                Console.WriteLine("arr[{2}] = {0} > arr[{3}] = {1}", arr[pos], arr[pos - 1], pos, pos - 1);
        }
        else
        {
            if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
                Console.WriteLine("arr[{0}] = {3} < arr[{1}] = {4} > arr[{2}] = {5}", pos - 1, pos, pos + 1, arr[pos - 1], arr[pos], arr[pos + 1]);
            if (arr[pos] < arr[pos - 1] && arr[pos] < arr[pos + 1])
                Console.WriteLine("arr[{0}] = {3} > arr[{1}] = {4} < arr[{2}] = {5}", pos - 1, pos, pos + 1, arr[pos - 1], arr[pos], arr[pos + 1]);
            if (arr[pos] > arr[pos - 1] && arr[pos] < arr[pos + 1])
                Console.WriteLine("arr[{0}] = {3} < arr[{1}] = {4} < arr[{2}] = {5}", pos - 1, pos, pos + 1, arr[pos - 1], arr[pos], arr[pos + 1]);
            if (arr[pos] < arr[pos - 1] && arr[pos] > arr[pos + 1])
                Console.WriteLine("arr[{0}] = {3} > arr[{1}] = {4} > arr[{2}] = {5}", pos - 1, pos, pos + 1, arr[pos - 1], arr[pos], arr[pos + 1]);
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 5, 4, 3, 5, 1, 0, 10, 9, 13, 51, 21, 1 };
        int index = 6; //note index count start from zero(0)
        CheckPrevNextE(index, array);
    }
}