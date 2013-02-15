using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMeSpapRef
{
    class Program
    {
        static int[,] Masiv()
        {
            return new int[3, 5] {
            {42,42,42,42,42},
            {42,42,42,42,42},
            {42,42,42,42,42} 
            };
            }
        static void Main(string[] args)
        {
            int[,] arr = new int[100, 100];
            arr = Masiv();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            }
        }


    }
