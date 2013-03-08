using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    class TestAnimal
    {
        static void Main()
        {
            List<Animal> array = new List<Animal>
            {
                new Dog("FilipGrozniqt",3,SexOfAnimal.Male),
                new Kitten("Lola",2,SexOfAnimal.Female),
                new Tomcat("Chernio",3,SexOfAnimal.Male),
                new Kitten("Shaini",5,SexOfAnimal.Female),
                new Frog("Kwako",3,SexOfAnimal.Male),
                new Kitten("Shiila",1,SexOfAnimal.Female)
            };

            double averageAge = array.Average(x => x.Age);

            Console.WriteLine(averageAge);

            foreach (var item in array)
            {
                Console.WriteLine("Animal type : {0}\n\t{1}",item.GetType().ToString().Substring(4,item.GetType().ToString().Length-4),item.ToString());
            }
        }
    }
}
