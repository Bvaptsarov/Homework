using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Boolean IsLeap = false;
    static void IsLeapYear(int y)
    {
        if (DateTime.IsLeapYear(y))
        {
            IsLeap = true;
            Console.WriteLine(IsLeap);
        }
        else Console.WriteLine(IsLeap);
    }
    static void Main(string[] args)
    {
        int y = int.Parse(Console.ReadLine());
        IsLeapYear(y);
    }
}
