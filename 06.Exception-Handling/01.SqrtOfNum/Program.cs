using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        SqrtOfNum(Console.ReadLine());
    }

    private static void SqrtOfNum(string p)
    {
        double sqrt;

        try
        {
            sqrt = double.Parse(p);
            if (sqrt <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else Console.WriteLine(Math.Sqrt(sqrt));
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid Number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Negative Number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}

