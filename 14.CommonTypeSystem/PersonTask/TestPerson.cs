using System;
using System.Linq;

namespace PersonTask
{
    class TestPerson
    {
        static void Main()
        {
            Person p = new Person("Bobi");
            Console.WriteLine(p);

            Person secondP = new Person("Kali", 15);
            Console.WriteLine(secondP);
        }
    }
}
