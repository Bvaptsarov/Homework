using System;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    class MultiTasks
    {
        /*Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
        * Use LINQ query operators.*/
        static void FirstBeforeLastName(Student[] array)
        {
            Console.WriteLine("Students whose first name is before its last name alphabetically : ");
            var query = from i in array
                        where i.FirstName.CompareTo(i.LastName) == -1
                        select i;

            foreach (var item in query)
            {
                Console.WriteLine(String.Format("{0} {1}", item.FirstName, item.LastName));
            }
        }

        
        static void AgeComparison(Student[] students)//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
        {
            Console.WriteLine("\nStudents with age between 18 and 24 : ");
            var query = from i in students
                        where i.Age >= 18 && i.Age <= 24
                        select i;

            foreach (var item in query)
            {
                Console.WriteLine(String.Format("{0} {1} {2}", item.FirstName, item.LastName,item.Age));
            }
        }

        
        static void OrderByNameLambda(Student[] students)//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. 
        {
            Console.WriteLine("\nLambda -  first name and last name in descending order : ");
            var items = students.OrderByDescending(x => x.FirstName).ThenByDescending(y => y.LastName);
            foreach (var item in items)
            {
                Console.WriteLine(String.Format("{0} {1}", item.FirstName, item.LastName));
            }
        }

        
        private static void OrderByNameLinq(Student[] students)//Rewrite the same with LINQ.
        {
            Console.WriteLine("\nLinq -  first name and last name in descending order : ");
            var items = from i in students
                        orderby i.FirstName descending, i.LastName descending
                        select i;

            foreach (var item in items)
            {
                Console.WriteLine(String.Format("{0} {1}", item.FirstName, item.LastName));
            }
        }

        
        private static int[] LambdaSelectionNumbers(int[] intArray)//All numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
        {
            return intArray.Where(x => x % 21 == 0).ToArray();
        }

        
        private static int[] LinqSelectionNumbers(int[] intArray)//linq version
        {
            return (from i in intArray
                   where i % 21 == 0
                   select i).ToArray();
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Kiro","Asparuhov",19),
                new Student("Borislav","Vaptsarov",21),
                new Student("Gabriel","Georgiev",21),
                new Student("Uknown","Aleksiev",12),
                new Student("Filip","Filipov",88)
            };

            FirstBeforeLastName(students);
            AgeComparison(students);
            OrderByNameLambda(students);
            OrderByNameLinq(students);

            //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
            int[] intArray = new int[50];
            Parallel.For(1, intArray.Length+1, x => intArray[x-1] = x);

            var viaLambda = LambdaSelectionNumbers(intArray);
            var viaLinq = LinqSelectionNumbers(intArray);

            Console.WriteLine("\nLambda - select all numbers that are divisible by 7 and 3 (21) from 1..50 : ");
            Console.WriteLine(String.Join(",", viaLambda) + "\n");
            Console.WriteLine("LINQ- select all numbers that are divisible by 7 and 3 (21) from 1..50 : ");
            Console.WriteLine(String.Join(",", viaLinq) + "\n");
        }

        
  
        
    }
}