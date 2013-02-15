using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Boolean[] markedSentences;
    static readonly char[] delimerDot = { '.' };
    static readonly char[] delimer = { ' ' };

    static void Main(string[] args)
    {
        String text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        String keyword = "in";
        CheckSentences(text, keyword);
    }

    private static void CheckSentences(string text, string keyword)
    {
        String[] dotSplit = text.Split(delimerDot);
        markedSentences = new Boolean[dotSplit.Length];
        for (int i = 0; i < dotSplit.Length; i++)
        {
            string[] words = dotSplit[i].Split(delimer, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == keyword) markedSentences[i] = true;
            }
        }
        PrintSenteces(dotSplit);
    }

    private static void PrintSenteces(string[] dotSplit)
    {
        for (int i = 0; i < dotSplit.Length; i++)
        {
            if (markedSentences[i]) Console.WriteLine(dotSplit[i].TrimStart()+".");
        }
    }
}

