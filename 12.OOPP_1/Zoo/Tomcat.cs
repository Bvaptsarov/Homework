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
            return "Meow~";
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", base.ToString(), MakeSound());
        }
    }
}
