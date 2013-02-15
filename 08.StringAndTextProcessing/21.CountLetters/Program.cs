using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<char, int> dict = new Dictionary<char, int>();
    private static readonly char[] delim = { '.', ',', ' ' };
    static void Main(string[] args)
    {
        String text = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();
        String[] splitted = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < splitted.Length; i++)
        {
            for (int j = 0; j < splitted[i].Length; j++)
            {
                if (dict.ContainsKey(splitted[i][j]))
                    dict[splitted[i][j]]++;
                else dict.Add(splitted[i][j], 1);
            }
        }
        var sorted = dict.OrderBy(x => x.Key);
        foreach (var i in sorted)
            Console.WriteLine(i);
    }
}

