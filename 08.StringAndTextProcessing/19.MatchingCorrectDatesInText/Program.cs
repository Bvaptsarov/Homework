using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static readonly char[] delim = { ' ' };
    static void Main(string[] args)
    {
        String text = "50.10.1002 22.05.1991 25.25.1991 60.30.12 filip 25.05.1991 kotka 28.06.1992";
        String[] split = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);        
        foreach (string i in split)
        {
           DateTime date;
           var f = DateTime.TryParseExact(i, "dd.MM.yyyy", new CultureInfo("en-CA"),DateTimeStyles.None,out date);
           if (f) Console.WriteLine(date.Date);
           else continue;
        }
    }
}
