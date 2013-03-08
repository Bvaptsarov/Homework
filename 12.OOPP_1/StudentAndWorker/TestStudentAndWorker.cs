using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAndWorker
{
    class TestStudentAndWorker
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Kiril","Antonov",3),
                new Student("Filip","Kostadinov",2),
                new Student("Martin","Ivanov",3),
                new Student("Petur","Iliev",5),
                new Student("Viktoriq","Velkova",5),
                new Student("Borislav","Vaptsarov",6),
                new Student("Niko","Traktorista",4),
                new Student("Kalina","Petrova",6),
                new Student("Gabriel","Georiev",2),
                new Student("Kiril","Marinov",4)
            };

            Console.WriteLine("Students : ");

            var sortedStudentsByGrade = from i in students //long linq selection
                                        orderby i.Grade ascending
                                        select i;

            foreach (var i in sortedStudentsByGrade)
            {
                Console.WriteLine(new string(' ',5) + i);
            }

            //----------------------------------------------------------

            Worker[] workers = new Worker[]
            {
                new Worker("Kostadin","Traikov",120.4,22.5),
                new Worker("Anton","Petrov",50,10),
                new Worker("Petur","Stoqnov",10,1),
                new Worker("Boiko","Borisov",90,18),
                new Worker("Keremid","Tolstolopev",1,1),
                new Worker("Borislav","Vaptsarov",1000,8),
                new Worker("Misho","Kirilov",50,10),
                new Worker("Kalina","Petrova",500,8),
                new Worker("Gab","Georiev",2,2),
                new Worker("Kiril","Nikolov",50,8)
            };

            Console.WriteLine("Workers : ");

            var sortedWorkersByMoneyPerHours = workers.OrderByDescending(x => x.MoneyPerHours()); //short linq ordering

            foreach (var i in sortedWorkersByMoneyPerHours)
            {
                Console.WriteLine(new string(' ', 5) + i);
            }

            //--------------------- mergin both students and worker and sorting them via first and last name

            Console.WriteLine("\nMergin both students and worker and sorting them via first and last name : \n");

            List<Human> merge = new List<Human>();
            merge.AddRange(students);
            merge.AddRange(workers);
            
            var sortedMergeViaFirstAndLastName = from i in merge
                                                 orderby i.FirstName,i.LastName
                                                 select i;
            
            foreach (var i in sortedMergeViaFirstAndLastName)
            {
                Console.WriteLine(i.FirstName + " " + i.LastName);
            }
        }
    }
}