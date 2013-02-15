using System;
using System.Linq;
/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
*/
class Program
{
    static Random rnd = new Random();
    static void Minimum<T>(T[] arr)
    {
        Console.WriteLine("Minimum = {0}",arr.Min());
    }
    static void Maximum<T>(T[] arr)
    {
        Console.WriteLine("Maximum = {0}",arr.Max());
    }
    static void Average<T>(T[] arr)
    {
        dynamic temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        Console.WriteLine("Average = {0}",(double)((temp*1.0)/arr.Length));
    }
    static void Sum<T>(T[] arr)
    {

        dynamic temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            temp += arr[i];
        }
        Console.WriteLine("Sum = {0}",temp);
    }
    static void Product<T>(T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        Console.WriteLine("Product = {0}", product);
    }
    static void Main(string[] args)
    {
        //int version
        Console.WriteLine("Int Version");
        int[] arr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            arr[i] = rnd.Next(1,10);
        }
        Minimum(arr);// Minimum
        Maximum(arr);//Maximum
        Average(arr); //Average
        Sum(arr); //sum;
        Product(arr); //Products
        Console.WriteLine("\nDouble Version");
        //double version
        double[] dArr = new double[10];
        for (int i = 0; i < 10; i++)
        {
            dArr[i] = rnd.NextDouble();
        }
        Minimum(dArr);// Minimum
        Maximum(dArr);//Maximum
        Average(dArr); //Average
        Sum(dArr); //sum;
        Product(dArr); //Products
        

    }
}
