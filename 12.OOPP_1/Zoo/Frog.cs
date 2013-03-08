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

        public override string ToString()
        {
            return String.Format("{0} - {1}", base.ToString(), MakeSound());
        }
    }
}
