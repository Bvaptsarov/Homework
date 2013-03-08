using System;
using System.Linq;

namespace SchoolDemo
{
    public class Student : Person, IComment
    {
        public String ID { get; private set; }
        public string Note { get; set; }

        public Student(string firstName ,string lastName, string id)
            : base(firstName,lastName)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentNullException("The give argument is null or have only white spaces");
            else
            {
                ID = id;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\nID - {1}\n", base.ToString(), ID);
        }      
    }
}
