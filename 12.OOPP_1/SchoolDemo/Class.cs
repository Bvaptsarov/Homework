using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolDemo
{
    public class Class : IComment
    {
        public String ClassName { get; private set; }
        public string Note { get; set; }
        public List<Teacher> TeachersList { get; private set; }
        public List<Student> StudentsList { get; private set; }

        public Class(string name, Teacher[] teach, Student[] stud)
        {
            if (String.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("The give argument is null or have only white spaces");
            else
            {
                ClassName = name;
                TeachersList = new List<Teacher>(teach);
                StudentsList = new List<Student>(stud);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine(string.Format("Class name - {0}", ClassName));
            str.AppendLine("Students : \n");

            foreach (var i in StudentsList)
            {
                str.AppendLine(i.ToString());
            }

            str.AppendLine("Teachers : \n");

            foreach (var i in TeachersList)
            {
                str.AppendLine(i.ToString());
            }

            return str.ToString();
        }
    }
}
