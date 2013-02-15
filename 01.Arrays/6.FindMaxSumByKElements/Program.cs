using System;
using System.Text;
/* Combinacii na redica -- Borislav Vaptsarov & kolegite ot foruma na telerik */
class Program
{
   
    static void Main(string[] args)
    {
        int n;
        bool isN = int.TryParse(Console.ReadLine(), out n);
        if (isN)
        {
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            int sum=0;
            Console.Write("Redica : ");
            for (int i = n-1; i >= n-k; i--)
            {
                sum += arr[i];
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n Sum : " + sum);
        }
    }
}