using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static readonly char[] delim = {' '};
    static void Main(string[] args)
    {
        String strParse = Console.ReadLine();
        string[] tmp = strParse.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;
        for (int i = 0; i < tmp.Length; i++)
        {
            sum += int.Parse(tmp[i]);
        }
        Console.WriteLine(sum);
    }
}
