using System;
class Program
{
    static string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

    static string LastElement(int num)
    {
        return arr[num % 10].ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(LastElement(Convert.ToInt32(Console.ReadLine())));
    }
}