using System;
using System.Linq;

namespace NamingIdentifiers
{
    class ConsoleWriter
    {
        const int MaxCount = 6; //not used yet

        public static void Main()
        {
            var instance = new ConsoleWriter.BooleanMethods();
            instance.PrintArgument(true);
        }

        class BooleanMethods
        {
            public void PrintArgument(bool givenBool)
            {
                string bolleanAsString = givenBool.ToString();
                Console.WriteLine(bolleanAsString);
            }
        }
    }
}
