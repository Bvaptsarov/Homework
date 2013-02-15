using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static StringBuilder str = new StringBuilder();
    private static readonly char[] delimer = { ' ' };
    static void Main(string[] args)
    {
        String text = @"az axa exe ti vie 12321 kiroepedal lol lolz kiflalfik pedroegei";
        string[] split = text.Split(delimer, StringSplitOptions.RemoveEmptyEntries);
        foreach (string i in split)
        {  
            for (int j = i.Length-1; j >= 0; j--)
            {
                str.Append(i[j]);
            }

            if (i==str.ToString())
            {
                Console.WriteLine("The word - \"{0}\" is a palindrom",i);
            }
            str.Clear();
        }
    }
}

