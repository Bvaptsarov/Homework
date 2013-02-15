using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    
    static void Main(string[] args)
    {
        String url = Console.ReadLine();
        UrlParse(url);
    }

    private static void UrlParse(string url)
    {
        String[] Protocol = url.Split(':');
        int index = Protocol[1].IndexOf("//");
        int finalIndex = Protocol[1].IndexOf("/",3);
        Console.WriteLine("[Protocol] = \"{0}\"",Protocol[0]);
        Console.WriteLine("[Server] = \"{0}\"",Protocol[1].Substring(2,finalIndex-2));
        Console.WriteLine("[Resource] = \"{0}\"", Protocol[1].Substring(finalIndex+1, Protocol[1].Length - finalIndex-1));
    }
}
