using System;

class Program
{
    static readonly int counterInt = 1;
    static Boolean[,] check;

    public static bool IsOutOfBoundsOrVisited(int[,] array, int i, int j)
    {
        return (i < 0 || i > array.GetLength(0) - 1) || (j < 0 || j > array.GetLength(1) - 1) || check[i, j];
    }

    private static int GetMaxArea(int[,] array, int value, int i, int j)
    {
        if (IsOutOfBoundsOrVisited(array,i,j)) return 0;
        else if (array[i, j] == value)
        {
            check[i, j] = true;
            return GetMaxArea(array, value, i + 1, j) + GetMaxArea(array, value, i, j + 1) + GetMaxArea(array, value, i - 1, j) + GetMaxArea(array, value, i, j - 1) + counterInt;
        }
        else return 0;
    }
    static void Main(string[] args)
    {
        int temp, counter;
        int[,] array = {{1,3,2,2,2,4},{3,3,3,2,4,4},{4,3,1,2,3,3},{4,3,1,3,3,1},{4,3,3,3,1,1}};
        check = new bool[array.GetLength(0), array.GetLength(1)];
        temp = counter = 0;
      
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                counter = GetMaxArea(array, array[i, j], i, j);
                if (counter > temp) temp = counter;
                if (i + 1 == array.GetLength(0) && j + 1 == array.GetLength(1)) Console.WriteLine(temp);
            }
    }

}
