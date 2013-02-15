using System;
using System.Linq;
using System.Text;

class ConvertFromXtoYSystem
{
    private static long XtoDec(string str, int system)
    {
        long sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            sum += long.Parse(str[i].ToString()) * (long)(Math.Pow(system, str.Length - (i + 1)));
        }
        return sum;
    }
    private static string DecToY(long num, int system)
    {
        StringBuilder str = new StringBuilder();
        while (num > 0)
        {
            str.Append(Rem(num % system));
            num /= system;
        }
        return str.ToString();
    }

    private static char Rem(long p)
    {
        switch (p)
        {
            case 0: return '0'; 
            case 1: return '1'; 
            case 2: return '2'; 
            case 3: return '3'; 
            case 4: return '4'; 
            case 5: return '5'; 
            case 6: return '6';
            case 7: return '7';
            case 8: return '8';
            case 9: return '9'; 
            case 10: return 'A'; 
            case 11: return 'B'; 
            case 12: return 'C'; 
            case 13: return 'D'; 
            case 14: return 'E'; 
            case 15: return 'F'; 
        }
        return '-';
    }

    static void Main(string[] args)
    {
        Console.WriteLine("2<=first<second<=16");
        int first, second;
        first = int.Parse(Console.ReadLine());
        second = int.Parse(Console.ReadLine());
        Console.WriteLine("Write a number in {0} system",first);
        string number = Console.ReadLine();
        string fin = DecToY(XtoDec(number,first),second);
        for (int i = fin.Length-1; i >=0; i--)
        {
            Console.Write(fin[i]);
        }
        Console.WriteLine();
    }
}
