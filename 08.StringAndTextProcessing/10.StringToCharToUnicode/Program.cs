using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        byte[] unibyte = Encoding.Unicode.GetBytes(str);
        string uniString = string.Empty;
        foreach(byte b in unibyte)
        {
            if(b.ToString("X") == @"0"){continue;}
            else uniString += string.Format("{0}{1}", @"\u00", b.ToString("X"));
        }
        Console.WriteLine(uniString);
    }
}

