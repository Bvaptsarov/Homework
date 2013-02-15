using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<string, int> dict = new Dictionary<string, int>();
    private static readonly char[] delim = { '.', ',', ' ' };
    static void Main(string[] args)
    {
        String text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example.".ToLower();
        String[] splitted = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < splitted.Length; i++)
        {
            if (dict.ContainsKey(splitted[i]))
                dict[splitted[i]]++;
            else dict.Add(splitted[i], 1);
        }
        var sorted = dict.OrderBy(x => x.Key);
        foreach(var i in sorted)
            Console.WriteLine(i);
    }
}

