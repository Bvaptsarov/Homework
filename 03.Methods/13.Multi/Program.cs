using System;
using System.Linq;
class Program
{   
    static char[] delimiterChars = {'*','+','=',' '};
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 for reversing a digit, 2 for calculating the average of array and 3 for linear equation");
        int press = int.Parse(Console.ReadLine());
        
        switch (press)
        {
            case 1: Reverse(); break;
            case 2: CalculateAverage(); break;
            case 3: QuadraticFunc(); break; //input test 10*x+12=3 //output x = -0.9
            default: Console.WriteLine("Wrong input"); break;
        }
    }

    private static void QuadraticFunc()
    {
        Console.Clear();
        int first, second, third;
        String str = Console.ReadLine();
        String[] slit = str.Split(delimiterChars);
        int[] arr = new int[3];
        arr[0] = int.Parse(slit[0].Trim());
        arr[1] = int.Parse(slit[2].Trim());
        arr[2] = int.Parse(slit[3].Trim());
        Console.WriteLine("x = {0}", (double)((arr[2]-arr[1])*1.0/arr[0]));
        
    }

    private static void CalculateAverage()
    {
        Console.Clear();
        int iter = int.Parse(Console.ReadLine());
        if (iter > 0)
        {
            int sum = 0;
            for (int i = 0; i < iter; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine((double)((sum * 1.0) / iter));
        }
        else Console.WriteLine("Incorect input");
    }

    private static void Reverse()
    {
        Console.Clear();
        Console.WriteLine("Write the digits!");
        Decimal d = Decimal.Parse(Console.ReadLine());
        if (d > 0)
        {
            string str = Convert.ToString(d);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
        else Console.WriteLine("Incorrect Value");
    }
}
