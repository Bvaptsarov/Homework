using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string tmp = Console.ReadLine();
        Console.WriteLine(IsCorrect(tmp));
    }

    private static bool IsCorrect(string tmp)
    {
        if (tmp.IndexOf(')') < tmp.IndexOf('(')) return true;
        else
        {
            int counter = 0;
            char[] arr = tmp.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(') counter++;
                else if (arr[i] == ')') counter--;
                if (counter < 0) break;
            }
            if (counter < 0) return false;
            else if (counter == 0) return true;
            else return false;
        }
    }
}

