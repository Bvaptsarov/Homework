using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static StringBuilder str = new StringBuilder();
    static void Main(string[] args)
    {
        ulong num = ulong.Parse(Console.ReadLine());
        while (num > 0)
        {
            str.Append(Rem(num % 16));
            num /= 16;
        }
        Console.Write("0x");
        for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i].ToString());
        Console.WriteLine();
       
    }

    private static char Rem(ulong p)
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
}

