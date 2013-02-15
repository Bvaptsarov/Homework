using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComparesArray
{
    static void Main(string[] args)
    {
        int n, m;
        bool isN, isM;
        Console.WriteLine("Input the size of the first and the second array");
        isN = int.TryParse(Console.ReadLine(), out n);
        isM = int.TryParse(Console.ReadLine(), out m);
        if (isN && isM)
        {
            int[] array = new int[n];
            int[] array_2 = new int[m];
            Console.WriteLine("Input the elements of the first array");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Input the elements of the second array");
            for (int i = 0; i < m; i++)
            {
                array_2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Comparing the elements");
            int br = 0;
            while (br != Math.Max(n, m))
            {
                if (m >= n)
                {
                    if (br < n && array[br] > array_2[br]) Console.Write("Index {0} - Element {1}\t >", br, array[br]);
                    else if (br < n && array[br] < array_2[br]) Console.Write("Index {0} - Element {1}\t <", br, array[br]);
                    else if (br < n && array[br] == array_2[br]) Console.Write("Index {0} - Element {1}\t =", br, array[br]);
                    else Console.Write("Index -1 - Element -1");
                    if (br < m) Console.WriteLine("\t Index {0} - Element {1}", br, array_2[br]);
                    else Console.Write("\t Index -1 - Element -1");
                    br++;
                }
                else
                {
                    if (br < m && array[br] > array_2[br]) Console.Write("Index {0} - Element {1}\t >", br, array_2[br]);
                    else if (br < m && array[br] < array_2[br]) Console.Write("Index {0} - Element {1}\t <", br, array_2[br]);
                    else if (br < m && array[br] == array_2[br]) Console.Write("Index {0} - Element {1}\t =", br, array_2[br]);
                    else Console.Write("Index -1 - Element -1");
                    if (br < n) Console.WriteLine("\t Index {0} - Element {1}", br, array[br]);
                    else Console.Write("\t Index -1 - Element -1");
                    br++;
                }
            }
        }
    }
}

//vtori metod,zaradi neto4noto yslovie 
/*
using System;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        bool isTrue = true;
        int[] arr, arr_2;
        int size, size_2;
        Console.Write("Goleminata na purviqt masiv : ");
        size = int.Parse(Console.ReadLine());
        arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Goleminata na vtoriqt masiv : ");
        size_2 = int.Parse(Console.ReadLine());
        if (size == size_2)
        {
        arr_2 = new int[size_2];
        for (int i = 0; i < size_2; i++)
        {
            arr_2[i] = int.Parse(Console.ReadLine());
        }
            //Parallel.For(0,size,index=>arr[index]!=arr_2[index],Console.Write(false));
            for (int i = 0; i < size; i++)
            {
                if (arr[i] != arr_2[i]) { isTrue = false; break; }
            }
            Console.WriteLine(isTrue);
        }
        else Console.WriteLine("The Arrays are not equal.");
    }
}
*/