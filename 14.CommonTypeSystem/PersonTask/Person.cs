using System;
using System.Linq;

namespace PersonTask
{
    public class Person
    {
        public String Name { get; set; }
        public int? Age { get; set; }

        public Person(String name, int? age=null)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return String.Format("Name - {0}\nAge - {1}", Name, Age == null ? "Unspecified" : Convert.ToString(Age));
        }
    }
}
