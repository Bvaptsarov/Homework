using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Dog : Animal,ISound
    {
        public Dog(string name, int age, SexOfAnimal sex) : base(name,age,sex)
        {
        }

        public string MakeSound()
        {
            return "Bayyyy";
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", base.ToString(), MakeSound());
        }
    }
}
