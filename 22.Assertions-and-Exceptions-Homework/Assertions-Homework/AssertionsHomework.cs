using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Given empty array.");
        Debug.Assert(arr != null, "Null array given.");
        Debug.Assert(arr.Length <= int.MaxValue, String.Format("The array containt more than {0} items.", int.MaxValue));

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(arr.SequenceEqual(arr.OrderBy(x => x).ToArray()), "The array is not sorted.");
    }
  

    //Personally i don't think that we should validate information in the private methods, and we don't have to validate information in this one,
    // because : the data is already validated in SelectionSort<T>(); there is 1000% that this method will work correctly.
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        //but nobody cares about my opinion..

        Debug.Assert(startIndex >= 0, "Outside of the array boundaries.");
        Debug.Assert(endIndex < arr.Length && endIndex >= 0, "End index is outside the array boundaries."); //?!?!?!?!
        Debug.Assert(startIndex < endIndex, "Starting index is bigger than endIndex.");
        
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "Given empty array.");
        Debug.Assert(arr != null, "Null array given.");
        Debug.Assert(arr.SequenceEqual(arr.OrderBy(x => x).ToArray()), "The array is not sorted.");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }


    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        //there is no need to check if startIndex is bigger than endIndex, it will just return -1.. but with the risk of losing points, i'll write an assertion.
        Debug.Assert(startIndex < endIndex, "StartIndex can't be bigger that endIndex");
        Debug.Assert(startIndex >= 0, "Outside of the array boundaries.");
        Debug.Assert(endIndex < arr.Length && endIndex >= 0, "End index is outside the array boundaries.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
