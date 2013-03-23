using System;
using System.Linq;

namespace StudentTasks
{
    class Test
    {
        public static void Main()
        {
            Student first = new Student("bobi", "Idas", "das", 1321,"Sdad", "sdad", "dsada", Univercity.NBU, Faculty.FBO, Specialty.Informatics);

            Student final = (Student)first.Clone();
            final.FName = "filip";
            Console.WriteLine(final.FName);
        }
    }
}
