using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDemo
{
    class TestSchoolDemo
    {
        static void Main()
        {
            Student[] inFirstClass = new Student[] 
            {
                new Student("Alex","Borisov","1"),
                new Student("Borislav","Vaptsarov","2"),
                new Student("Kiril","Voinov","3")
            };

            Student[] inSecondClass = new Student[] 
            {
                new Student("Fili[","Borisov","1"),
                new Student("Megan","Vasilova","2"),
                new Student("Aspartan","E525","3")
            };

            Discipline[] firstDiscipline = new Discipline[]
            {
                new Discipline("Mathematics",2,5),
                new Discipline("Algorithms",3,8),
                new Discipline("Sleeping",10,24)
            };

            Discipline[] secondDiscipline = new Discipline[]
            {
                new Discipline("Physics",2,5),
                new Discipline("Hitting",3,8),
                new Discipline("Peeing on ppl",2,4)
            };

            Teacher[] teachers = new Teacher[]
            {
                new Teacher("Ivan","Kostolov",firstDiscipline),
                new Teacher("Troll","Mogilov",secondDiscipline)
            };

            Teacher[] teachersS = new Teacher[]
            {
                new Teacher("Troll","Mogilov",secondDiscipline)
            };

            Class[] classes = new Class[]
            {
                new Class("12A",teachers,inFirstClass),
                new Class("12B",teachers,inSecondClass)
            };

            School thisSChool = new School("PMG - Akad. Ivan Guzelev", classes);
            Console.WriteLine(thisSChool);
        }
    }
}