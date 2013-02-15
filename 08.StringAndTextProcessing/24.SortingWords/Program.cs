using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    private static readonly char[] delim = { ' ', ',', '.' };
    static void Main(string[] args)
    {
        String text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
        var sorted = text.Split(delim, StringSplitOptions.RemoveEmptyEntries).OrderBy(x=>x);
        foreach (var i in sorted)
            Console.WriteLine(i);
    }
}

