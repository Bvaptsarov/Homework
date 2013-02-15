using System;
using System.Linq;
using System.Text;
class Matrix
{
    private int row;
    private int col;
    private int[,] arr;

    //empty contructor
    Matrix()
    {
        //def
        arr = new int[0, 0];
    }

    //constructor with parameters
    Matrix(int row, int col)
    {
        this.row = row;
        this.col = col;
        arr = new int[row, col];
    }

    //setter - param (row,col,data)//getter - param (row,col) return int
    public int this[int col, int row]
    {
        get
        {
            return this.arr[col, row];
        }
        set
        {
            this.arr[col, row] = value;
        }
    }
    //Override ToString()
    public override string ToString()
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < this.row; i++)
        {
            for (int j = 0; j < this.col; j++)
            {
                str.Append((new String('[', 1)) + this.arr[i, j] + (new String(']', 1)) + " ");
            }
            str.AppendLine();
        }
        return str.ToString();
    }

    public static Matrix operator +(Matrix x, Matrix y)
    {
        Matrix tempArr = new Matrix(x.row, x.col);
        for (int i = 0; i < x.row; i++)
            for (int j = 0; j < x.col; j++)
                tempArr[i, j] = x[i, j] + y[i, j];

        return tempArr;
    }
    public static Matrix operator -(Matrix x, Matrix y)
    {
        Matrix tempArr = new Matrix(x.row, x.col);
        for (int i = 0; i < x.row; i++)
            for (int j = 0; j < x.col; j++)
                tempArr[i, j] = x[i, j] - y[i, j];

        return tempArr;
    }
    public static Matrix operator *(Matrix x, Matrix y)
    {
        Matrix tempArr = new Matrix(x.row, x.col);
        for (int i = 0; i < x.row; i++)
            for (int j = 0; j < x.col; j++)
                for (int k = 0; k < x.col; k++)
                    tempArr[i, j] = x[i, k] * y[k, j];

        return tempArr;
    }

    static void Main(string[] args)
    {
        Matrix first = new Matrix(5, 5);
        Matrix second = new Matrix(5, 5);

        Random rnd = new Random();
        for (int i = 0; i < first.row; i++)
        {
            for (int j = 0; j < first.col; j++)
            {
                first[i, j] = rnd.Next(100);
                second[i, j] = rnd.Next(100);
            }
        }
        Console.WriteLine(first+second);
        Console.WriteLine(second+first);
        Console.WriteLine(first - second);
        Console.WriteLine(second - first);
        Console.WriteLine(first*second);
        Console.WriteLine(second*first);
        
    }
}

// 1 2 3
// 1 2 3
// 1 2 3

// 2 2 2
// 2 2 2
// 2 2 2

//12 12 12
//12 12 12
//12 12 12