using System;
using System.Text.RegularExpressions;
using System.IO;

class Program
{
    static MatchCollection m;
    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    m = Regex.Matches(reader.ReadLine(), @"(?<=^|>)[^><]+?(?=<|$)");
                    foreach (var i in m)
                        Console.WriteLine(i.ToString().Trim());
                }
            }
        }
        catch (IOException IOE)
        {
            Console.WriteLine(IOE.Message);
        }
    }
}

