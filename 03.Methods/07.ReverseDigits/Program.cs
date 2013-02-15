using System;

class ReverseDig
{
    static void ReverseDigits(String temp)
    {
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            Console.Write(temp[i]);
        }
        Console.WriteLine();

    }
    static void Main(string[] args)
    {
        ReverseDigits(Console.ReadLine()); //works not only with digits
    }
}

