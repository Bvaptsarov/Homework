using System;
using System.Linq;

class HexToDec
{
    static void Main(string[] args)
    {
        String input = Console.ReadLine();
        ulong dec = 0;
        for (int i = 0; i < input.Length; i++)
        {
            dec += (input[i] >= 'A' ? ulong.Parse((input[i] - 'A').ToString()) + 10 : ulong.Parse((input[i] -'0').ToString()))*(ulong)(Math.Pow(16,input.Length-(i+1)));
        }
        Console.WriteLine(dec);
    }
}

