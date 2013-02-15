using System;
public class GeneratePermutations
{
    static void Permut(int k, int n, int[] nums)
    {
        int m, p, temp;
        if (k <= n)
        {
            for (m = k; m <= n; m++)
            {
                temp = nums[m];
                for (p = m; p > k; p--)
                {
                    nums[p] = nums[p - 1];
                }
                nums[k] = temp;

                /* recurse on k+1 to n */

                Permut(k + 1, n, nums);
                for (p = k; p < m; p++)
                {
                    nums[p] = nums[p + 1];
                }
                nums[m] = temp;
            }
        }
        else
        {
            Console.Write("{");
            for (m = 1; m <= n; m++)
            {
                Console.Write("{0}", nums[m]);
                if (m < n)
                {
                    Console.Write(",");
                }
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] rgNum = new int[n+1];
        for (int i = 1; i <= n; i++)
        {
            rgNum[i] = i;
        }
        Console.Write("Permutations:\n");
        Permut(1, n, rgNum);
    }
}