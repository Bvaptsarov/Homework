using System;

class Program
{
    static char[] alphaBet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    static void Main(string[] args)
    {
        string str = Console.ReadLine().ToLower();
        Console.Clear();
        Console.WriteLine(str);
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(Array.IndexOf(alphaBet, str[i]) + " ");
        }
    }
}
