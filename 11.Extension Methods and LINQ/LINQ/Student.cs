using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaLINQ
{
    public class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public Student(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }
    }
}
