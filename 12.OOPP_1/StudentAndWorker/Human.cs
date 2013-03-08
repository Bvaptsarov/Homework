using System;
using System.Linq;

namespace StudentAndWorker
{
    public abstract class Human
    {
        public String FirstName { get; private set; }
        public String LastName { get; private set; }

        public Human(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
