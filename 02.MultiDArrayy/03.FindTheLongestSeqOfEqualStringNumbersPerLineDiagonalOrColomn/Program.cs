using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int[,] maxLine = new int[n + 1, m + 1];
        String[,] maxLen = new String[n + 1, m + 1];
        String[,] array = new String[n + 2, m + 2];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                array[i, j] = Console.ReadLine();

        int diagonalStep, max, temp;
        string longSeq;
        string tempStr = null;
        diagonalStep = max = temp = 0;
        //redove
        for (int i = 0; i < n; i++)
        {
            longSeq = array[i, 0];
            max = 0;
            temp = 0;
            for (int j = 1; j <= m; j++)
            {
                if (array[i, j] == array[i, j - 1]) { temp++; tempStr = array[i, j]; }
                else if (temp > max) { max = temp; longSeq = tempStr; tempStr = null; temp = 0; }
                else { tempStr = null; temp = 0; }
            }
            maxLine[0, i] = max + 1;
            maxLen[0, i] = longSeq;
        }
        //stulbove
        for (int i = 0; i <= n; i++)
        {
            longSeq = array[0, i];
            max = 0;
            temp = 0;
            for (int j = 1; j <= m; j++)
            {
                if (array[j, i] == array[j - 1, i]) { temp++; tempStr = array[j, i]; }
                else if (temp > max) { max = temp; longSeq = tempStr; tempStr = null; temp = 0; }
                else { tempStr = null; temp = 0; }
            }
            maxLine[1, i] = max + 1;
            maxLen[1, i] = longSeq;
        }
        //goren lqv do dolen desen diagonal  
        max = 0;
        temp = 0;
        for (int i = 0; i <= Math.Min(n, m); i++)
        {
            longSeq = array[i, diagonalStep];
            if (array[i + 1, diagonalStep + 1] == array[i, diagonalStep])
            {
                temp++;
                tempStr = array[i, diagonalStep];
            }
            else if (temp > max) { max = temp; longSeq = tempStr; tempStr = null; temp = 0; }
            maxLine[2, 0] = max + 1;
            maxLen[2, i] = longSeq;
            diagonalStep++;
        }
        //goren desen - > dolen lqv diagonal
        diagonalStep = n-2;
        max = 0;
        temp = 0;
        longSeq = array[0, diagonalStep];
        for (int i = 1; i < Math.Min(n, m); i++)
        {
            longSeq = array[i, diagonalStep];
            if (array[i + 1, diagonalStep + 1] == array[i, diagonalStep])
            {
                temp++;
                tempStr = array[i, diagonalStep];
            }
            else if (temp > max) { max = temp; longSeq = tempStr; tempStr = null; temp = 0; }

            maxLine[3, 0] = max + 2;
            maxLen[3, i-1] = longSeq;
            diagonalStep--;
        }
        Console.WriteLine("----------------------------");
        int maxCol = maxLine[1,0];
        string tmp = maxLen[1,0];
        for (int i = 0; i < m; i++)
        {
            if (maxCol < maxLine[1, i]) { maxCol = maxLine[1, i]; tmp = maxLen[1, i]; }       
        }
        Console.WriteLine((maxLine[0, 0] > maxCol && maxLine[0, 0] > maxLine[2, 0])? maxLen[0,0] : (maxLine[2, 0] > maxCol && maxLine[2, 0] > maxLine[0, 0])? maxLen[2,0]:tmp);
    }
}

