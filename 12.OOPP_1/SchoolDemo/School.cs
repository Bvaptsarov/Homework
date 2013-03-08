using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolDemo
{
    public class School
    {
        public String SchoolName { get; private set; }
        public List<Class> Classes { get; set; }
        
        public School()
        {
            SchoolName = null;
            Classes = new List<Class>();
        }

        public School(string name, Class[] arr)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("The give argument is null or have only white spaces");
            else
            {
                SchoolName = name;
                Classes = new List<Class>(arr);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(String.Format("School name - {0}\n\n", SchoolName));

            foreach (var item in Classes)
            {
                str.AppendLine(item.ToString());
            }

            return str.ToString();
        }
    }
}
