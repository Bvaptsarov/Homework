using System;
class Program
{
    static void Main(string[] args)
    {
        int first, second, third;
        first = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        third = int.Parse(Console.ReadLine());
        int max = first;

        GetMax(ref max, second);
        GetMax(ref max, third);

        Console.WriteLine(max);
    }

    private static void GetMax(ref int max, int temp)
    {
        if (max < temp) max = temp;
    }
}

