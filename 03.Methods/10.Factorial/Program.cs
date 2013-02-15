using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            FactorialCall(i);
        }
    }
  
    private static void FactorialCall(int i)
    {
        BigInteger temp = new BigInteger();
        temp = 1;
        for (int j = 1; j <= i; j++)
        {
            temp *= i;
        }
        Console.WriteLine(temp);
    }
}
