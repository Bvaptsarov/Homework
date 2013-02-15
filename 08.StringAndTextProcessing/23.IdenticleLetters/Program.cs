using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder str = new StringBuilder();
        String text = @"aaaaabbbbbcdddeeeedssaa";
        str.Append(text[0]);
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1]) str.Append(text[i]);
        }
        Console.WriteLine(str);
    }
}

