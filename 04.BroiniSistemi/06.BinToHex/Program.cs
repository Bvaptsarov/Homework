using System;
using System.Linq;
using System.Text;

class Program
{
    static StringBuilder inFor = new StringBuilder();
    static StringBuilder fin = new StringBuilder();
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string final;
        if (input.Length % 4 != 0)
        {
            final = new String('0', (4 - input.Length%4)) + input;
        }
        else final = input;

        for (int i = 0; i < final.Length; i++)
        {
            inFor.Append(final[i]);
            if ((i + 1) % 4 == 0)
            {
                BinToHex(inFor.ToString());
                inFor.Clear();
            }
        }
        Console.Write("0x");
        Console.WriteLine(fin);
    }
  
    private static void BinToHex(String tmp)
    {
        switch (tmp)
        {
            case "0000": fin.Append(0); break;
            case "0001": fin.Append(1); break;
            case "0010": fin.Append(2); break;
            case "0011": fin.Append(3); break;
            case "0100": fin.Append(4); break;
            case "0101": fin.Append(5); break;
            case "0110": fin.Append(6); break;
            case "0111": fin.Append(7); break;
            case "1000": fin.Append(8); break;
            case "1001": fin.Append(9); break;
            case "1010": fin.Append("A"); break;
            case "1011": fin.Append("B"); break;
            case "1100": fin.Append("C"); break;
            case "1101": fin.Append("D"); break;
            case "1111": fin.Append("F"); break;
        }
    }
}

