using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<String> array = new List<String>();
        array.Add("ax");
        array.Add("az");
        array.Add("aasd");
        array.Add("wqx");
        array.Add("qwrx");
        array.Add("aa");
        array.Add("tqx");
        array.Add("mah");
        array.Add("dwax");
        
        array.Sort((x, y) => x.CompareTo(y));
        Console.WriteLine(String.Join(" ", array.OrderBy(x=>x.Length)));
    }
}
