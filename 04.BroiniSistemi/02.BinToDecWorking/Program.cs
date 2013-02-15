using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        String str = Console.ReadLine();
        ulong sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            sum += ulong.Parse(str[i].ToString())*(ulong)(Math.Pow(2, str.Length - (i + 1) ));
        }
        Console.WriteLine(sum);
    }
}
