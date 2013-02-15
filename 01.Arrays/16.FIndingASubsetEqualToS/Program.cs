using System;
using System.Text;
/* * We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
*/
class Program
{
    static void Comb(int[] arr,int Sum)
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
            for (int m = 0; m < split.Length; m++)
            {
                tempSum = tempSum + int.Parse(split[m]);
            }
            if (tempSum == Sum) 
            {
                Console.WriteLine("Yes");
                Console.WriteLine(str.ToString() + "= " + Sum); 
            }
            tempSum = 0;
            str.Clear();
            Array.Clear(split, 0, split.Length);
        }
    }
    static void Main(string[] args)
    {
        //golemina na masiv
        int n;
        bool isN = int.TryParse(Console.ReadLine(), out n);
        if (isN)
        {
            int S = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Comb(arr,S);
        }
    }
}