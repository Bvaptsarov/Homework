using System;

class Program
{
    static void CheckPrevNextE(int[] arr)
    {
        Boolean t = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                if (arr[0] > arr[1])
                {
                    Console.WriteLine(0);
                    t = true;
                    break;
                }
            }
            if (i == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1])
                {
                    Console.WriteLine(i);
                    t = true;
                    break;
                }
            }
            if (i > 0 && i < arr.Length - 1)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    Console.WriteLine(i);
                    t = true;
                    break;
                }
            }
        }
        if (t == false)
        {
            Console.WriteLine("-1");
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 3, 3, 3, 6, 7, 2 };
        CheckPrevNextE(array);//return index
    }
}