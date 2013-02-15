using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static readonly char[] delimer = { ' ', ',', '.' };
    static void Main(string[] args)
    {
        String text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        String keyword = "PHP, CLR, Microsoft";
        CheckSentences(text, keyword);
    }

    private static void CheckSentences(string text, string keyword)
    {
        string[] array = keyword.Split(delimer, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder str = new StringBuilder();
        str.Append(text);
        for (int i = 0; i < array.Length; i++)
        {
            str.Replace(array[i], new String('*', array[i].Length));
        }
        Console.WriteLine(str.ToString());
    }
}

