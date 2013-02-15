using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FloatBinRepresentation
{
    class Program
    {
        static StringBuilder str = new StringBuilder(34);
        static readonly char[] sep = { '-' };
        static void Main(string[] args)
        {
            float num = float.Parse(Console.ReadLine());
            byte[] arr = BitConverter.GetBytes(num);
            Array.Reverse(arr);
            string tmp = BitConverter.ToString(arr);
            String[] final = tmp.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < final.Length; i++)
			{
                for (int j = 0; j < 2; j++)
			    {
                    HexToBin(final[i][j].ToString());
			    }
			}
            str.Insert(1, ' ');
            str.Insert(10, ' ');
            Console.WriteLine(str.ToString());
        }
        private static void HexToBin(string temp)
        {
            switch (temp)
            {
                case "0": str.Append("0000"); break;
                case "1": str.Append("0001"); break;
                case "3": str.Append("0011"); break;
                case "4": str.Append("0100"); break;
                case "5": str.Append("0101"); break;
                case "6": str.Append("0110"); break;
                case "7": str.Append("0111"); break;
                case "8": str.Append("1000"); break;
                case "9": str.Append("1001"); break;
                case "A": str.Append("1010"); break;
                case "B": str.Append("1011"); break;
                case "C": str.Append("1100"); break;
                case "D": str.Append("1101"); break;
                case "E": str.Append("1110"); break;
                case "F": str.Append("1111"); break;
                default: str.Append(""); break;
            }
        }
    }
}
