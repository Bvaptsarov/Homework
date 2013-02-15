using System;

class Program
{

    static void Main(string[] args)
    {
        int n;
        bool isN = int.TryParse(Console.ReadLine(), out n);
        if (isN)
        {
            printA(n);
            Console.WriteLine();
            printB(n);
            Console.WriteLine();
            printC(n);
            Console.WriteLine();
            printD(n);
        }
    }
    public static void printD(int n)
    {
        int br = 1, m=0, p=0;
        int[,] arr = new int[n, n];
        int[,] temp = new int[n, n];
        for (int i = arr.GetUpperBound(0), j = 0; i >= 0; i--, j++)
        {
            for (int k = j; k < i; k++)
            {
                arr[j, k] = br;
                br++;
            }
            for (int k = j; k < i; k++)
            {
                arr[k, i] = br;
                br++;
            }
            for (int k = i; k > j; k--)
            {
                arr[i, k] = br;
                br++;
            }
            for (int k = i; k > j; k--)
            {
                arr[k, j] = br;
                br++;
            }
        }
        for (int i = 0; i < arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] == 0) { arr[i, j] = br; br++; }
            }
        }

        for (int i = arr.GetUpperBound(0); i>=0; i--)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                temp[m, p] = arr[j, i];
                p++;
            }
            p = 0;
            m++;
        }
        for (int i = n-1; i >=0; i--)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(temp[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void printC(int n)
    {
        int fill = 1;
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j >= 0; j--)
            {
                arr[i, j] = fill;
                fill++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
    private static void printB(int n)
    {
        int fill = 1;
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j, i] = fill;
                    fill++;
                }
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    arr[j, i] = fill;
                    fill++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
    public static void printA(int n)
    {
        int fill = 1;
        int[,] arr = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[j, i] = fill;
                fill++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}

