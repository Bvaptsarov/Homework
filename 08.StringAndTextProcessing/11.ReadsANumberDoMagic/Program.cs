using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
*/
class Program
{
    static void Main(string[] args)
    {
        int number;
        Boolean isNum = int.TryParse(Console.ReadLine(), out number);
        if (isNum)
        {
            Console.WriteLine("Decimal number {0:D}", number);
            Console.WriteLine("Hexidecimal number {0:X}",number);
            Console.WriteLine("Percentage {0}",number.ToString("P"));
            Console.WriteLine("Scrientific Notation number {0:E}",number);
        }
    }
}

