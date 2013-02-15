using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Dictionary<string, string> dic = new Dictionary<string, string>();
    static void Main(string[] args)
    {
        dic.Add(".Net", "platform for applications from Microsoft.");
        dic.Add("CLR", "managed execution environment for .NET.");
        dic.Add("namespace", "hierarchical organization of classes.");
        string str = Console.ReadLine();
        Console.WriteLine(str + " - " +dic[str]);
    }
}

