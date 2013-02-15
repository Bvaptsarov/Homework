using System;
using System.Text;
/* 
 * * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.
*/
class Program
{
    protected static Boolean IsExist = false;
    static void Comb(int[] arr, int sum, int countK)
    {
        int tempSum = 0;
        StringBuilder str = new StringBuilder();
        for (int i = 1; i <= Math.Pow(2, arr.Length) - 1; i++)
        {
            string temp = Convert.ToString(i, 2).PadLeft(arr.Length, '0');
            for (int j = 0; j < temp.Length; j++)
            {
                if (temp[j] == '1')
                {
                    str.Append(arr[j] + " ");
                }
            }
            string[] split = str.ToString().Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
            if (split.Length == countK)
            {
                for (int m = 0; m < split.Length; m++)
                {
                    tempSum = tempSum + int.Parse(split[m]);
                }
                if (tempSum == sum)
                {
                    IsExist = true;
                    Console.WriteLine(str.ToString() + "= " + sum);
                }
            }
            
            tempSum = 0;
            str.Clear();
            Array.Clear(split, 0, split.Length);
        }
        if (!IsExist)
            {
                Console.WriteLine("No"); 
            }
    }
    static void Main(string[] args)
    {
        //golemina na masiv
        int n;
        bool isN = int.TryParse(Console.ReadLine(), out n);
        if (isN)
        {
            int K = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Comb(arr, S,K);
        }
    }
}