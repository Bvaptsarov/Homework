using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static StringBuilder str = new StringBuilder(64);
    
    static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        while (number > 0)
        {
            str.Append(number % 2);
            number /= 2;
        }

        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
        Console.WriteLine();
    }
}

