using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(ToUpperCase(text,"<upcase>","</upcase>"));
    }

    private static string ToUpperCase(string text,string tag,string closeTag)
    {
        StringBuilder str = new StringBuilder();
        str.Append(text);
        int indexer = 0;
        int closingTag = 0;
        while (indexer >=0)
        {
            indexer = str.ToString().IndexOf(tag);
            closingTag = str.ToString().IndexOf(closeTag);
            if (indexer!=-1 || closingTag !=-1)
            {
                string temp = str.ToString().Substring(indexer + tag.Length, closingTag - (indexer + tag.Length));
                str.Remove(indexer, temp.Length+closeTag.Length+tag.Length);
                str.Insert(indexer, temp.ToUpper());    
            }
        }
        return str.ToString();
    }
}

