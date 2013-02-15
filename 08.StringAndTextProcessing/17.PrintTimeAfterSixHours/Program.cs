using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        date = date.AddHours(6.5);
        String dayOfTheWeek = date.ToString("dddd");
        Console.WriteLine("After 6 hours and 30 minutes it will be {0},{1}",date,dayOfTheWeek);
    }
}

