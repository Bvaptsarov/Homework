using System;
using System.Diagnostics;
using System.Linq;

namespace MathUtilsComparingPerfomances
{
    static class MathUtils
    {
        static void SquareRootUtil()
        {
            DisplayExecutionTime(() =>
            {
                for (float i = 1.1f; i < 1000; i++)
                {
                    Math.Sqrt(i);
                }
            }, "Square root Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 1.1; i < 1000; i++)
                {
                    Math.Sqrt(i);
                }
            }, "Square root Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)1.1; i < 1000; i++)
                {
                    Math.Sqrt((double)i);
                }
            }, "Square root Decimal");
        }

        static void NaturalLogUtil()
        {
            DisplayExecutionTime(() =>
            {
                for (float i = 1.1f; i < 1000; i++)
                {
                    Math.Log10(i);
                }
            }, "NaturalLog Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 1.1; i < 1000; i++)
                {
                    Math.Log10(i);
                }
            }, "NaturalLog Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)1.1; i < 1000; i++)
                {
                    Math.Log10((double)i);
                }
            }, "NaturalLog Decimal");
        }

        static void SinusUtil()
        {
            DisplayExecutionTime(() =>
            {
                for (float i = 1.1f; i < 1000; i++)
                {
                    Math.Sin(i);
                }
            }, "Sinus Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 1.1; i < 1000; i++)
                {
                    Math.Sin(i);
                }
            }, "Sinus Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)1.1; i < 1000; i++)
                {
                    Math.Sin((double)i);
                }
            }, "Sinus Decimal");
        }

        static void DisplayExecutionTime(Action action, string typeInfo)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(typeInfo + " - " + stopwatch.Elapsed);
        }

        static void Main(string[] args)
        {
            SquareRootUtil();
            NaturalLogUtil();
            SinusUtil();
        }
    }
}