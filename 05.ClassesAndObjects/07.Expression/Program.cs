using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //under development, far from finished
    static int leftOpenBrackets = 0;
    static void Main(string[] args)
    {
        String expression = @"pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(') leftOpenBrackets++;
        }
        Calculate(expression);
    }

    private static void Calculate(string str)
    {
        string substr = "";
        for (int i = 0; i < 1; i++)
        {
            int lastOpen = str.LastIndexOf("(");
            int indexClose = str.IndexOf(")",lastOpen);
            substr = str.Substring(lastOpen+1, indexClose - lastOpen-1);
            Console.WriteLine(substr);
            CheckOperation(str.Substring(lastOpen - 4, lastOpen));
        }
    }

    private static void CheckOperation(string p)
    {
        throw new NotImplementedException();
    }
}

