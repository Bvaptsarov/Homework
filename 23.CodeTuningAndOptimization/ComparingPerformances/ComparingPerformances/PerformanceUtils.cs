using System;
using System.Diagnostics;
using System.Linq;

namespace PrimitiveTypeComparingPerformances
{
    static class PerformanceUtils
    {
        static void AddUtils()
        {
            DisplayExecutionTime(() =>
            {
                for (int i = 100; i < 1000; i += 2)
                {
                }
            }, "Adding Int");

            DisplayExecutionTime(() =>
            {
                for (long i = 100; i < 1000; i += 2)
                {
                }
            }, "Adding Long");

            DisplayExecutionTime(() =>
            {
                for (float i = 100.1f; i < 1000.1; i += 2f)
                {
                }
            }, "Adding Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 100.1; i < 1000.1; i += 2)
                {
                }
            }, "Adding Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)100.1, lastIndex = (decimal)1000.1; i < lastIndex; i += 2)
                {
                }
            }, "Adding Decimal");
        }

        static void SubStractUtils()
        {
            DisplayExecutionTime(() =>
            {
                for (int i = 1000; i > 100; i -= 2)
                {
                }
            }, "SubStract Int");

            DisplayExecutionTime(() =>
            {
                for (long i = 1000; i > 100; i -= 2)
                {
                }
            }, "SubStract Long");

            DisplayExecutionTime(() =>
            {
                for (float i = 1000.1f; i > 100.1; i -= 2f)
                {
                }
            }, "SubStract Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 1000.1; i > 100.1; i -= 2)
                {
                }
            }, "SubStract double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)1000.1, lastIndex = (decimal)100.1; i > lastIndex; i -= 2)
                {
                }
            }, "SubStract Decimal");
        }

        static void IncrementUtils()
        {
            DisplayExecutionTime(() =>
            {
                for (int i = 100; i < 1000; i ++)
                {
                }
            }, "Increment Int");

            DisplayExecutionTime(() =>
            {
                for (long i = 100; i < 1000; i++)
                {
                }
            }, "Increment Long");

            DisplayExecutionTime(() =>
            {
                for (float i = 100.1f; i < 1000.1; i++)
                {
                }
            }, "Increment Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 100.1; i < 1000.1; i++)
                {
                }
            }, "Increment Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)100.1, lastIndex = (decimal)1000.1; i < lastIndex; i++)
                {
                }
            }, "Increment Decimal");
        }

        static void MultiplyUtils()
        {
            DisplayExecutionTime(() =>
            {
                for (int i = 100; i < 10000000; i *= 2)
                {
                }
            }, "Multiply Int");

            DisplayExecutionTime(() =>
            {
                for (long i = 100; i < 10000000; i *= 2)
                {
                }
            }, "Multiply Long");

            DisplayExecutionTime(() =>
            {
                for (float i = 100.1f; i < 10000000.1; i *= 2f)
                {
                }
            }, "Multiply Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 100.1; i < 10000000.1; i *= 2)
                {
                }
            }, "Multiply Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)100.1, lastIndex = (decimal)10000000.1; i < lastIndex; i *= 2)
                {
                }
            }, "Multiply Decimal");
        }

        static void DivideUtils()
        {
            DisplayExecutionTime(() =>
            {
                for (int i = 10000000; i > 100; i /= 2)
                {
                }
            }, "Divide Int");

            DisplayExecutionTime(() =>
            {
                for (long i = 10000000; i > 100; i /= 2)
                {
                }
            }, "Divide Long");

            DisplayExecutionTime(() =>
            {
                for (float i = 10000000.1f; i > 100.1; i /= 2f)
                {
                }
            }, "Divide Float");

            DisplayExecutionTime(() =>
            {
                for (double i = 10000000.1; i > 100.1; i /= 2)
                {
                }
            }, "Divide Double");

            DisplayExecutionTime(() =>
            {
                for (decimal i = (decimal)10000000.1, lastIndex = (decimal)100.1; i > lastIndex; i /= 2)
                {
                }
            }, "Divide Decimal");
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
            AddUtils();
            SubStractUtils();
            IncrementUtils();
            MultiplyUtils();
            DivideUtils();
        }
    }
}