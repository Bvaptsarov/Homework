using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

public class LatinToMorseOrRev
{
    static sbyte br = 0;
    static StringBuilder str = new StringBuilder();
    static Stopwatch sw = new Stopwatch();
    static Random rand = new Random();
    static readonly String[] morseCode = { ".-",/*b*/"-...",/*c*/"-.-.",/*d*/"-..",/*e*/".",/*f*/"..-.",/*g*/"--.",/*h*/"....",/*i*/"..",/*j*/".---",/*K*/"-.-",/*L*/".-..",/*M*/"--",/*N*/"-.",/*O*/"---",/*P*/".--.",/*Q*/"--.-",/*R*/".-.",/*S*/"...",/*T*/"-",/*U*/"..-",/*V*/"...-",/*W*/".--",/*X*/"-..-",/*Y*/"-.--",/*z*/"--.." };
    static readonly char[] alphaBet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    public String text;
    static readonly object[] finalResults = new object[7];

    public LatinToMorseOrRev() { }
    public LatinToMorseOrRev(string str)
    {
        this.text = str;
    }

    public String GetText()
    {
        return this.text;
    }
    public void SetText(string str)
    {
        this.text = str;
    }

    public void ToText()
    {
        string[] arr = GetText().Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < morseCode.Length; j++)
            {
                if (arr[i] == morseCode[j]) { Console.Write(alphaBet[j]); break; }
            }
        }
    }

    public void ToMorse()
    {
        string t = GetText().ToLowerInvariant();
        for (int i = 0; i < t.Length; i++)
        {
            char ch = t[i];
            if (t[i] != ' ' && t[i] != '.' && t[i] != '!' && t[i] != '?' && t[i] != ',')
            {
                Console.Write(morseCode[(int)(ch - 97)] + " ");
            }
            else Console.Write(" ");
        }
    }

    public void TestPrintTextToMorse(int n)
    {
        Thread.Sleep(5000);
        for (int i = 0; i < n; i++)
        {
            str.Append(alphaBet[rand.Next(0, alphaBet.Length)]);
        }
        LatinToMorseOrRev test = new LatinToMorseOrRev(str.ToString());
        sw.Start();
        test.ToMorse();
        str.Clear();
        sw.Stop();
        TimeSpan elapsedTime = sw.Elapsed;
        finalResults[br] = n + " for : " + elapsedTime;
        br++;
        sw.Reset();
        Console.WriteLine("\n" + elapsedTime);
    }


    public void TestPrintMorseToText(int p)
    {
        Thread.Sleep(5000);
        for (int i = 0; i < p; i++)
        {
            str.Append(morseCode[rand.Next(0, morseCode.Length)] + " ");
        }
        LatinToMorseOrRev test = new LatinToMorseOrRev(str.ToString());
        sw.Start();
        test.ToText();
        str.Clear();
        sw.Stop();
        TimeSpan elapsedTime = sw.Elapsed;
        finalResults[br] = p + " for : " + elapsedTime;
        br++;
        sw.Reset();
        Console.WriteLine("\n" + elapsedTime);
    }

    public void Result()
    {
        foreach (object i in finalResults)
        {
            Console.WriteLine(i);
        }
        Array.Clear(finalResults, 0, finalResults.Length);
        br = 0;
    }

    static void Main(string[] args) { }
}
