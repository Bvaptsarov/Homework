using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/

namespace Extensions.IEnumExtensions
{
    public static class IEnumExtension
    {
        public static T Sum<T>(this IEnumerable<T> array)
        {
            if (array.Count() == 0 || array == null) throw new IEnumException("The given array is empty");
            else
            {
                dynamic sum = 0;
                foreach (var i in array)
                {
                    sum += i;
                }
                return sum;
            }
        }

        public static T Product<T>(this IEnumerable<T> array)
        {
            if (array.Count() == 0 || array == null) throw new IEnumException("The given array is empty");
            else
            {
                dynamic sum = 1;
                foreach (var i in array)
                {
                    sum *= i;
                    if (sum == 0) break;
                }
                return sum;
            }
        }

        public static T Min<T>(this IEnumerable<T> array)
        {
            if (array.Count() == 0 || array == null) throw new IEnumException("The given array is empty");
            else
            {
                dynamic min = array.First();
                foreach (var i in array)
                {
                    if (min > i) min = i;
                }
                return min;
            }
        }

        public static T Max<T>(this IEnumerable<T> array)
        {
            if (array.Count() == 0 || array == null) throw new IEnumException("The given array is empty");
            else
            {
                dynamic min = array.First();
                foreach (var i in array)
                {
                    if (min < i) min = i;
                }
                return min;
            }
        }

        public static Decimal Average<T>(this IEnumerable<T> array)
        {
            if (array.Count() == 0 || array == null) throw new IEnumException("The given array is empty");
            else
            {
                decimal sum = 0;
                foreach (var i in array)
                {
                    sum += Convert.ToDecimal(i);
                }
                return sum / array.Count();
            }
        }
    }
}
