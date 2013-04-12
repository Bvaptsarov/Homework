using System;
using System.Linq;

namespace NamingIdentifiers
{
    enum Gender
    {
        Male,
        Female
    };

    class MainClass
    {
        public void CreateHuman(int age)
        {
            Human instanceOfHuman = new Human();
            instanceOfHuman.Age = age;

            if (age % 2 == 0)
            {
                instanceOfHuman.FullName = "Cool guy";
                instanceOfHuman.Sex = Gender.Male;
            }
            else
            {
                instanceOfHuman.FullName = "Cool chick";
                instanceOfHuman.Sex = Gender.Female;
            }
        }

        class Human
        {
            public Gender Sex { get; set; }

            public string FullName { get; set; }

            public int Age { get; set; }
        }
    }
}