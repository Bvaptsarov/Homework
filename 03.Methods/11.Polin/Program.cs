using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        decimal[] first = { 2, -5, 2, -8 }; // 2x^3 - 5x^2 + 2x^1 - 8 = 0
        decimal[] second = { -4, 2, 1 }; //-4x^2 + 2x^1 +1 = 0;
        //result 2x^3 -9x^2 + 4x^1 -7x^0 = 0
        SumPoly(first, second);
    }

    private static void SumPoly(decimal[] first, decimal[] second)
    {
        Array.Reverse(first);
        Array.Reverse(second);
        decimal[] final = new decimal[Math.Max(first.Length, second.Length)];
        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            final[i] = first[i] + second[i];
            if (i + 1 == Math.Min(first.Length, second.Length))
            {
                for (int j = i + 1; j < Math.Max(first.Length, second.Length); j++)
                {
                    if (first.Length > second.Length)
                    {
                        final[j] = first[j];
                    }
                    else if (second.Length > first.Length)
                    {
                        final[j] = second[j];
                    }
                    else
                        final[j] = second[j];
                }
            }
        }
        Array.Reverse(final);
        for (int i = 0; i < final.Length; i++)
        {
            if (i + 1 != final.Length)
            {
                if (final[i] > 0) Console.Write(final[i] + "x^" + (final.Length - i - 1) + " ");
                else Console.Write(final[i] + "x^" + (final.Length - i - 1) + " + ");
            }
            else Console.Write(final[i] + "x^" + (final.Length - i - 1) + " ");
        }
        Console.WriteLine("= 0");
    }
}