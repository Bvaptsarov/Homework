using System;
using System.Linq;

namespace Zoo
{
    public abstract class Animal 
    {
        public Int32 age;
        public String name;
        public SexOfAnimal Sex { get; set; }

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))               
                    throw new ArgumentException("Name cannot be null or empty.");
                else name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 0)
                    this.age = value;
                else
                    throw new ArgumentOutOfRangeException("Age cannot be negative number");
            }
        }

        public Animal(string name, int age, SexOfAnimal sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}, {2}", Name, Age, Sex);
        }
    }
}