using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        if (str.Length > 20) Console.WriteLine("Maximum Characters Exceeded");
        else
        {
            byte dlm = (byte)(20 - str.Length);
            Console.WriteLine(str+new string('*',dlm));
        }
    }
}

