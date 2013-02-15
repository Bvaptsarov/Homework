using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Program
{
    static readonly char[] delim = { ' ' };
    static void Main(string[] args)
    {
        String text = @"kiro.asparuxob@abv.bg mitko@abv.b..bg.bg fili@gmail.com kifla123412321@slarudw.eu.ax filmi@.. parcal@mail.bg";
        String regex = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
        string[] spl = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
        foreach (var i in spl)
        {
            var match = Regex.IsMatch(i, regex);
            if (match) Console.WriteLine("Valid - {0}",i);
            else Console.WriteLine("Invalid - {0}",i);
        }
        
    }
}


