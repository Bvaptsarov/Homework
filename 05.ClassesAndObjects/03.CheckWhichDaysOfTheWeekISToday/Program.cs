using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //enum DaysOfWeek{Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
    static DateTime day = DateTime.Now;
    static void Main(string[] args)
    {
        Console.WriteLine(day.DayOfWeek.ToString());
    }
}

