using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleArea
{
    static readonly double Pi = Math.PI;
    public static double Surface(double a, double b,double c)
    {
        double p = (a + b + c)/2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public static double Surface(double a, double b, float angle)
    {
        return ((a * b) * Math.Sin((angle*Pi)/180))/2;
    }
    public static double Surface(double side, double h)
    {
        return (side * h) / 2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Surface(13,14, c:15));//tri strani
        Console.WriteLine(Surface(13,14, angle: 30)); //with angle
        Console.WriteLine(Surface(15,20));//s viso4ina
    }
}

