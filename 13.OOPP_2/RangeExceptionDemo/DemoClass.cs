using System;
using System.Linq;

namespace RangeExceptionDemo
{
    class DemoClass
    {
        static void NumberTest(int start, int end, int number)
        {
            try
            {
                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>("The number was not in range :", start, end, number);
                }
                else Console.WriteLine("In range of {0}<{1}<{2}", start, number, end);
            }
            catch (InvalidRangeException<int>)
            {
                Console.WriteLine("The number - {0}, was not in range of {1}..{2}",number,start,end);
            }
        }

        static void DateTest(DateTime from, DateTime to, DateTime input)
        {
            try
            {
                if (from > input || input > to)
                {
                    throw new InvalidRangeException<DateTime>("The date was not in range :", from, to, input);
                }
            }
            catch (InvalidRangeException<DateTime>)
            {
                Console.WriteLine("The date - {0}, was not in range of {1}..{2}", from, to, input);
            }
        }

        static void Main(string[] args)
        {
           
            NumberTest(1,100,1000);//NumberTest(from,to, value to check);
            DateTest(new DateTime(1991, 5, 25), new DateTime(2013, 3, 10), new DateTime(2014, 5, 25)); //DateTest(from,to,dateToCheck);
        }

       
    }
}
