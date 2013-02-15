using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

class Program : LatinToMorseOrRev
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please input '1' for text to morse, write down '2' for morse to text, '3' for the test(from text to morse) and '4' for the test (from morse to text)!");
        sbyte option;
        bool isOp = sbyte.TryParse(Console.ReadLine(), out option);
        Console.Clear();
        if (isOp && option == 1)
        {
            LatinToMorseOrRev test = new LatinToMorseOrRev();
            Console.WriteLine("Please write the text in lat alphabet, below it you will get the morse equivalent");
            test.SetText(Console.ReadLine());
            test.ToMorse();
            Console.WriteLine();
        }
        else if (isOp && option == 2)
        {
            LatinToMorseOrRev test = new LatinToMorseOrRev();
            Console.WriteLine("Please write down the morse code (separating each symbol by space)");
            test.SetText(Console.ReadLine());
            test.ToText();
            Console.WriteLine();
        }
        else if (isOp && option == 3)
        {
            LatinToMorseOrRev test = new LatinToMorseOrRev();
            Console.WriteLine("In 5 seconds, will appear test with 100 characters string to morse code, after that another for 500... etc");
            test.TestPrintTextToMorse(100);
            Console.WriteLine("In 5 seconds - test for 500...etc");
            test.TestPrintTextToMorse(500);
            Console.WriteLine("In 5 seconds - test for 1000...etc");
            test.TestPrintTextToMorse(1000);
            Console.WriteLine("In 5 seconds - test for 5000...etc");
            test.TestPrintTextToMorse(5000);
            Console.WriteLine("In 5 seconds - test for 10000...etc");
            test.TestPrintTextToMorse(10000);
            Console.WriteLine("In 5 seconds - test for 50000...etc");
            test.TestPrintTextToMorse(50000);
            Console.WriteLine("In 5 seconds - test for 100000...etc");
            test.TestPrintTextToMorse(100000);
            Console.WriteLine("All results will be shown in 3 seconds, pending...");
            Thread.Sleep(3000);
            Console.Clear();
            test.Result();
        }
        else if (isOp && option == 4)
        {
            LatinToMorseOrRev test = new LatinToMorseOrRev();
            Console.WriteLine("In 5 seconds, will appear test with 100 morse characters in string to alphabet code, after that another for 500... etc");
            test.TestPrintMorseToText(100);
            Console.WriteLine("In 5 seconds - test for 500...etc");
            test.TestPrintMorseToText(500);
            Console.WriteLine("In 5 seconds - test for 1000...etc");
            test.TestPrintMorseToText(1000);
            Console.WriteLine("In 5 seconds - test for 5000...etc");
            test.TestPrintMorseToText(5000);
            Console.WriteLine("In 5 seconds - test for 10000...etc");
            test.TestPrintMorseToText(10000);
            Console.WriteLine("In 5 seconds - test for 50000...etc");
            test.TestPrintMorseToText(50000);
            Console.WriteLine("In 5 seconds - test for 100000...etc");
            test.TestPrintMorseToText(100000);
            Console.WriteLine("All results will be shown in 3 seconds, pending...");
            Thread.Sleep(3000);
            Console.Clear();
            test.Result();
        }
        else Console.WriteLine("Incorect Input Value");
    }
}

