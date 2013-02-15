using System;
using System.Collections;

class Program
{
    public static ArrayList Merge(ArrayList inputArray)
    {
        if (inputArray.Count == 1)
        {
            return inputArray;
        }
        ArrayList arraySorted = new ArrayList();
        int leftPart = 0;
        int rightPart = 0;
        int middle = (int)inputArray.Count / 2;

        ArrayList leftArray = inputArray.GetRange(0, middle); 
        leftArray = Merge(leftArray);
        ArrayList rightArray = inputArray.GetRange(middle, inputArray.Count - middle);
        rightArray = Merge(rightArray);

        for (int i = 0; i < leftArray.Count + rightArray.Count; i++)
        {
            if (leftPart == leftArray.Count)
            {
                arraySorted.Add(rightArray[rightPart]);
                rightPart++;
            }
            else if (rightPart == rightArray.Count)
            {
                arraySorted.Add(leftArray[leftPart]);
                leftPart++;
            }
            else if ((int)leftArray[leftPart] < (int)rightArray[rightPart])
            {
                arraySorted.Add(leftArray[leftPart]);
                leftPart++;
            }
            else
            {
                arraySorted.Add(rightArray[rightPart]);
                rightPart++;
            }
        }
        return arraySorted;
    }
    static void Main(string[] args)
    {
        Random r = new Random();
        ArrayList arr = new ArrayList();
        for (int i = 0; i < 50; i++)
        {
            arr.Add(r.Next(50));
        }
        arr = new ArrayList(Merge(arr));
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

