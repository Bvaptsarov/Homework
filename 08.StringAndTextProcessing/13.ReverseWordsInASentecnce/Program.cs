using System;
using System.Linq;
using System.Text;

class Program
{
    static readonly char[] delim = { ',', ' ', '!' ,'.'};
    static void Main(string[] args)
    {
        String text = @"C# is not C++, not PHP and not Delphi !";
        char lastChar = text[text.Length - 1];
        String[] arr = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        for (int i = arr.Length - 1; i >= 0; i--)
        {
             Console.Write(arr[i] + " ");
        }
        Console.Write(lastChar+"\n");
    }
}

