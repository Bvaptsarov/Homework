using System;

namespace BitArray64Task
{
    class TestClass
    {
        static void Main()
        {
            BitArray64 tmp = new BitArray64(9999999999999);
            Console.WriteLine(tmp);
            Console.WriteLine("Changed BitArray with new values on some of the indexes");
            tmp[63] = 1; //from 63..0 -- 63 is the first bit from left to right
            tmp[55] = 1;
            tmp[0] = 0; //the first bit from right to left
            Console.WriteLine(tmp);

            Console.WriteLine("Iterate trought the BitArray");
            foreach (int item in tmp)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(tmp[63]);
      
        }
    }
}
