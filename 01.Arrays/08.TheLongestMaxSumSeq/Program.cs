using System;
using System.Text;
/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/
class Program
{
    static int sequence(int[] array)
    {
        int MaxSoFar = array[0], MaxEnding = array[0], begin, begin_temp, end;
        begin = begin_temp = end = 0;

        for (int i = 1; i < array.Length; i++)
        {
            MaxEnding += array[i];
            if (array[i] > MaxEnding)
            {
                MaxEnding = array[i];
                begin_temp = i;
            }

            if (MaxEnding > MaxSoFar)
            {
                MaxSoFar = MaxEnding;
                begin = begin_temp;
                end = i;
            }
        }
        for (int i = begin; i < begin + (end - begin) + 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
        return MaxSoFar;
    }
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int temp = sequence(arr);
        Console.WriteLine(temp);
    }
}

