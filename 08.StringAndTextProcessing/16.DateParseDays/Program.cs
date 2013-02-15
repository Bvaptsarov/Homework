using System;
using System.Linq;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        String firstDate = Console.ReadLine();
        String secondDate = Console.ReadLine();
        DateTime first = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime second = DateTime.ParseExact(secondDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine((second-first).TotalDays);
    }
}

