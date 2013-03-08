using System;
using System.Linq;

namespace Zoo
{
    public class Tomcat : Cat,ISound
    {
        public Tomcat(string name, int age, SexOfAnimal sex) : base(name,age,sex)
        {
        }

        public string MakeSound()
        {
            return "Male - Meow~";
        }
    }
}
