using System;
using System.Linq;

namespace Zoo
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, SexOfAnimal sex) : base(name,age,sex)
        {
        }

        public string MakeSound()
        {
            return "Kwak";
        }
    }
}
