using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        short number = short.Parse(Console.ReadLine());
        number = number <= 0 ? (short)(number + 1) : number;
        short num = number;
       
        for (int i = 15; i >= 0; i--)
        {
            if ((i + 1) % 4 == 0 && (i+1)!=16) Console.Write(" ");
            Console.Write(num < 0 ? (short)(number / (short)Math.Pow(2, i)) + 1 : (short)(number / (short)Math.Pow(2, i)));
            number = (short)(number % (short)Math.Pow(2, i));      
        }
        Console.WriteLine();
    }
}

