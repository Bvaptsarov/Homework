using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Random rnd;
    static void Main(string[] args)
    {
        GenerateNumbers(10);
    }

    private static void GenerateNumbers(int p)
    {
        rnd = new Random();
        for (int i = 0; i < p; i++)
        {
            Console.WriteLine(rnd.Next(100,201));
        }
    }
}

