using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static StringBuilder str = new StringBuilder();
    static void Main(string[] args)
    {
        String text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        str.Append(text);
        Replace(str);
    }

    private static void Replace(StringBuilder str)
    {
        str.Replace("<a href=\"", "[URL=");
        str.Replace("\">","]");
        str.Replace("</a>", "[/URL]");
        Console.WriteLine(str.ToString());
    }
}

