using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.IEnumExtensions
{
    class Test
    {
        //comment if u wanna test the StringBuilderExtensions
        static void Main()
        {
            IEnumerable<double> array = new double[]{123.321, 123.24, 1, 2, 3};

            Console.WriteLine(array.Sum<double>());
            Console.WriteLine(array.Product<double>());
            Console.WriteLine(array.Min<double>());
            Console.WriteLine(array.Max<double>());
            Console.WriteLine(array.Average<double>());
        }
    }
}
