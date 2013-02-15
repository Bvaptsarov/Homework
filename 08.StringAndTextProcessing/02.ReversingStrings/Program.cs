using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        StringBuilder final = new StringBuilder(str.Length);
        for (int i = str.Length-1; i >=0; i--)
        {
            final.Append(str[i]);
        }
        Console.WriteLine(final);
    }
}

