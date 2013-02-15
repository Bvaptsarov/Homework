using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int indexer = 0;
        string item = "in";
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        while(indexer!=-1){
            indexer = text.IndexOf(item,indexer+1);
            counter++;
        }
        Console.WriteLine(counter);
    }
}

