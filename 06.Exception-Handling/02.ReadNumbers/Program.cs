using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> arr = new List<int>();
    static void Main(string[] args)
    {
        Console.WriteLine("Write numbers for start and end on new line - start < end");
        try
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            ReadTenNumbers(start, end);
        }
        catch (FormatException)
        {
            Console.WriteLine("Exception - Not a number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Exception - Not in range");
        }
        catch (ArgumentNullException) 
        {
            Console.WriteLine("Exception - Null not a number"); 
        }
        finally
        {
            if (arr.Count != 0)
            {
                Console.WriteLine("Numbers till now!");
                for (int i = 0; i < arr.Count; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

    private static void ReadTenNumbers(int start, int end)
    {
        for (int i = 0; i < 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > start && num < end)
            {
                start = num;
                arr.Add(num);
            }
            else throw new ArgumentOutOfRangeException();
        }
    }
}

