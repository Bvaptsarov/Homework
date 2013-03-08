using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolDemo
{
    public class Teacher : Person, IComment
    {
        public List<Discipline> Discipline { get; private set; }
        public string Note { get; set; }

        public Teacher(string firstName, string lastName, Discipline[] array)
            : base(firstName, lastName)
        {
            Discipline = new List<Discipline>(array);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString()+"\n");

            foreach (var item in Discipline)
            {
                str.AppendLine(item.ToString()+"");
            }

            return str.ToString();
        }
    }
}
