using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] arr = new int[n,m];
        int[,] holds = new int[3, 3];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[i,j] = int.Parse(Console.ReadLine());
            }
        }
        //temporary hold best 3x3 matrix
        //maxni komentara ako iskash da razpe4atash maximalnata 3x3 matrica sled maximalnata suma v konzolata
        /*
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                holds[i, j] = arr[i, j];
            }
        }
         */
        int maxSum = arr[0, 0] + arr[0, 1] + arr[0, 2] + arr[1, 0] + arr[1, 1] + arr[1, 2] + arr[2, 0] + arr[2, 1] + arr[2, 2];
        int tempSum = 0;
        //checking

        for (int i = 0; i < n-2; i++)
        {
            for (int j = 0; j < m-2; j++)
            {
                tempSum = arr[i,j] + arr[i,j+1] + arr[i,j+2] + arr[i+1,j] + arr[i+1,j+1] + arr[i+1,j+2] + arr[i+2,j]+ arr[i+2,j+1] + arr[i+2,j+2];
                if(tempSum > maxSum) 
                { 
                    maxSum = tempSum;
                    //vuzmojnost za razpe4atvane na maximalnata 3x3 matrica, maxni komentara,ako iskash da se razpe4ata
                    /*
                    holds[0,0] = arr[i,j];
                    holds[0,1] = arr[i,j+1];
                    holds[0,2] = arr[i,j+2];
                    holds[1,0] = arr[i+1,j];
                    holds[1,1] = arr[i+1,j+1];
                    holds[1,2] = arr[i+1,j+2];
                    holds[2,0] = arr[i+2,j];
                    holds[2,1] = arr[i+2,j+1];
                    holds[2,2] = arr[i+2,j+2];
                     */
                }
            }
        }
        Console.WriteLine("MaxSum = "+ maxSum);
        //maxni komentara da razpe4atash maximalnata 3x3 matrica
        /*
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(holds[i, j] + " ");
            }
            Console.WriteLine();
        }
         */


        //test  input
        /*
         4
         4
         1 5 6 9
         3 5 10 10
         2 4 6 7
         1 2 3 4
         */
        //output 
        /*
         * MaxSum = 62

           5 6 9
           5 10 10
           4 6 7
         */
    }
}

