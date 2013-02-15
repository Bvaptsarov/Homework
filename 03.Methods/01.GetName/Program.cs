using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(PrintName(Console.ReadLine()));
    }

    private static string PrintName(string str)
    {
       return "Hello, " + str +"!";
    }
}

