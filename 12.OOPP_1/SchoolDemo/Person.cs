using System;
using System.Linq;

namespace SchoolDemo
{
    public class Person
    {
        public String FirstName { get; private set; }
        public String LastName { get; private set; }

        public Person()
        {
            FirstName = null;
            LastName = null;
        }

        public Person(string first, string second)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException(String.Format("One of the given params is null"));
            }
            else
            {
                FirstName = first;
                LastName = second;
            }
        }

        public override string ToString()
        {
            return String.Format("First name - {0}\nLast name - {1}", FirstName, LastName);
        }
    }
}
