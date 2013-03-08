using System;
using System.Linq;

namespace StudentAndWorker
{
    public class Worker : Human
    {
        private const int WorkingDays = 5; // 5 working days per week
        private double weekSalary;
        private double workHoursPerDay;

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value >= 0 && value <= 24)
                    this.workHoursPerDay = value;
                else
                    throw new ArgumentOutOfRangeException("Working hours per day must be a positive value and should be below 24!");
            }
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value >= 0)
                    this.weekSalary = value;
                else
                    throw new ArgumentOutOfRangeException("Salary must be a positive value!");
            }
        }

        public Worker(string first, string last, double salaryPerWeek, double workHoursPerDay) : base(first, last)
        {
            if (salaryPerWeek >= 0 && workHoursPerDay >= 0 && workHoursPerDay <= 24)
            {
                WeekSalary = salaryPerWeek;
                WorkHoursPerDay = workHoursPerDay;
            }
            else
                throw new ArgumentOutOfRangeException("Salary and working hours must be a positive value and working hours per day should be below 24!");
        }

        public decimal MoneyPerHours()
        {
            return (decimal)WeekSalary / (decimal)(WorkingDays * WorkHoursPerDay); 
        }

        public override string ToString()
        {
            return String.Format("{0} : \n\tWeek Salary - {1}\n\tWork hours per day - {2}\n\tMoney per hour - {3}",
                base.ToString(), WeekSalary, WorkHoursPerDay, MoneyPerHours());
        }
    }
}