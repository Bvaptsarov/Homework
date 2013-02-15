using System;
//Predlagam 2 metoda za reshavane na BInarySearch - Iterativen i Recursiven
class Program
{
    static int temp;

    public static int binarySearch(int[] array, int value)
    {
        if (array.Length <= 0 == false && array[0] <= value && array[array.Length - 1] >= value)
        {
            int over = array.Length;
            int overRight = array.Length;
            if ((overRight & 1) == 1)
            {
                overRight = array.Length / 2;
                over = array.Length / 2;
            }
            else
            {
                overRight = array.Length / 2 - 1;
                over = array.Length / 2 - 1;
            }
            while (true)
            {
                if (overRight >= array.Length) break;
                if (array[overRight] == value)
                {
                    temp = overRight;
                    goto b;
                }
                else if (array[overRight] > value)
                {
                    overRight = overRight / 2;
                    goto s;
                }
                else if (array[overRight] < value)
                {
                    over = over / 2;
                    overRight = overRight + over + 1;
                    goto s;
                }
                else return -1;
            s: ;
            }
        }
        else
            return -1;
    b: ;
        return temp;
    }
    static void Main(string[] args)
    {
        int[] arr = { 213, 214, 214312, 12, 3215, 1232, 1312, 3215, 123, 32151, 23131, 235414, 2133213 };
        Array.Sort(arr);

        int iterationBinarySearch = binarySearch(arr, 3215);
        int recursiveBinarySearch = Search(arr, 214, 0, arr.Length - 1);

        Console.WriteLine(iterationBinarySearch);
        Console.WriteLine(recursiveBinarySearch);
    }
    public static int Search(int[] array, int value, int leftSide, int rightSide)
    {
        if (array.Length <= 0 == false && array[0] <= value && array[array.Length - 1] >= value)
        {
            if (leftSide <= rightSide)
            {
                int middle = (leftSide + rightSide) / 2;
                if (value == array[middle])
                {
                    return middle;
                }
                else if (value < array[middle])
                {
                    return Search(array, value, leftSide, middle - 1);
                }
                else
                {
                    return Search(array, value, middle + 1, rightSide);
                }
            }
            return -1;
        }
        else return -1;
    }

}

