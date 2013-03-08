using System;
using System.Linq;

namespace StudentAndWorker
{
    public class Student : Human
    {
        public int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value >= 2 && value <= 6)
                    this.grade = value;
                else
                    throw new ArgumentOutOfRangeException("Grade must be number from 2..6");
            }
        }

        public Student(string firstName, string lastName, int grade) : base(firstName, lastName)
        {
            if (grade >= 2 && grade <= 6)
                Grade = grade;
            else
                throw new ArgumentOutOfRangeException("Grade must be number from 2..6");
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", base.ToString(), Grade);
        }
    }
}