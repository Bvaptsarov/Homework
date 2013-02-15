using System;

class Program
{
    static void Main(string[] args)
    {
        byte[] first = { 1, 7, 4, 2, 7, 8, 9, 0, 1, 2, 3, 4, 6, 1, 2 };
        byte[] second = { 5, 7, 8, 9, 1, 9, 2, 5 };
        SumOfArrays(first, second);
        //test with the mere numbers, if they are equal to the array -> it's fine
        Console.WriteLine(174278901234612+57891925);

        //second test - the first array get's the second array numbers and vice versa
        byte[] secondD = { 1, 7, 4, 2, 7, 8, 9, 0, 1, 2, 3, 4, 6, 1, 2 };
        byte[] firstT = { 5, 7, 8, 9, 1, 9, 2, 5 };
        SumOfArrays(firstT, secondD);

    }

    private static void SumOfArrays(byte[] first, byte[] second)
    {
        byte[] final = new byte[Math.Max(first.Length,second.Length)+1];
        Array.Reverse(first);
        Array.Reverse(second);
        byte addition = 0;
        byte temp = 0;
        for (int i = 0;i<Math.Min(first.Length,second.Length);i++)
        {
            temp = (byte)(first[i] + second[i] + addition);
            if (temp >= 10)
            {
                addition = 1;
                final[i] = (byte)(temp % 10);
            }
            else
            {
                addition = 0;
                final[i] = temp;
            }
            if (i + 1 == Math.Min(first.Length, second.Length))
            {
                for (int j = i+1; j < Math.Max(first.Length,second.Length); j++)
                {
                    if (first.Length > second.Length)
                    {
                        temp = (byte)(first[j] + addition);
                        if (temp >= 10)
                        {
                            addition = 1;
                            final[j] = (byte)(temp % 10);
                        }
                        else
                        {
                            addition = 0;
                            final[j] = temp;
                        }
                    }
                    else
                    {
                        temp = (byte)(second[j] + addition);
                        if (temp >= 10)
                        {
                            addition = 1;
                            final[j] = (byte)(temp % 10);
                        }
                        else
                        {
                            addition = 0;
                            final[j] = temp;
                        }
                    }
                    if (j + 1 == Math.Max(first.Length, second.Length) && addition == 1)
                    {
                        final[j + 1] = addition;
                    }
                }
            }
        }
        Array.Reverse(final);
        for (int i = 0; i < final.Length; i++)
        {
            if (i == 0 && i == final[i]) continue;
            else Console.Write(final[i]);
        }
        Console.WriteLine();
    }
}

