using System;

class Program
{
    static void Main(string[] args)
    {
        char[] firstArr = { 'a', 'g', 'f', 'a', 'q', 'w', 'm' };
        char[] secondArr = { 'b', 'c', 'w', 'h', 'j', 'g', 'q' };
        for (int i = 0; i < firstArr.Length; i++)
        {
            Console.WriteLine(firstArr[i] > secondArr[i] ? firstArr[i] + ">" + secondArr[i] : firstArr[i] + "<" + secondArr[i]);
        }
    }
}

//vtori metod - zaradi neto4no uslovie 
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        bool isTrue = true;
        char[] arr, arr_2;
        int size, size_2;
        Console.Write("Vuvedete goleminata na purviqt : ");
        size = int.Parse(Console.ReadLine());
        arr = new char[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = char.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        Console.Write("Vuvedete goleminata na vtoriqt : ");
        size_2 = int.Parse(Console.ReadLine());
        if (size == size_2)
        {
            arr_2 = new char[size_2];
            for (int i = 0; i < size_2; i++)
            {
                arr_2[i] = char.Parse(Console.ReadLine());
            }
            Array.Sort(arr_2);
            if (arr.Equals(arr_2) != false) isTrue = false;
            Console.WriteLine(isTrue);
        }
        else Console.WriteLine("Not Equal");
    }
}

*/