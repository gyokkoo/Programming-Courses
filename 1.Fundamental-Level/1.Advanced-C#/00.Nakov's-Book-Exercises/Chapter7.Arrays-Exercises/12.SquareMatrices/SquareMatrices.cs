using System;
/*
Write a program, which creates square matrices like those in the figures below and prints them formatted to the console. 
The size of the matrices will be read from the console. 
See the examples for matrices with size of 4 x 4 and make the other sizes in a similar fashion.
 */
class SquareMatrices
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        Console.WriteLine("A)");
        FillMatrixA(matrix, n);
        PrintMatrix(matrix, n);

        Console.WriteLine("B)");
        FillMatrixB(matrix, n);
        PrintMatrix(matrix, n);

        Console.WriteLine("C)");
        FillMatrixC(matrix, n);
        PrintMatrix(matrix, n);

        Console.WriteLine("D)");
        FillMatrixD(matrix, n);
        PrintMatrix(matrix, n);
    }

    static void FillMatrixD(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = 0;
            }
        }

        int row = 0;
        int col = 0;
        string direction = "down";

        for (int number = 1; number <= n * n; number++)
        {
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "right";
                row--;
                col++;
            }
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "up";
                col--;
                row--;
            }
            if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            {
                direction = "left";
                row++;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "down";
                col++;
                row++;
            }
            matrix[row, col] = number;

            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "left")
            {
                col--;
            }
        }
    }

    static void FillMatrixC(int[,] matrix, int n)
    {
        int rows = 0;
        int cols = 0;
        int number = 1;

        //populate values under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            rows = i;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[rows++, cols++] = number++;
            }
        }

        //populate values over the main diagonal
        for (int j = 1; j < n; j++)
        {
            rows = j;
            cols = 0;
            while (rows < n && cols < n)
            {
                matrix[cols++, rows++] = number++;
            }
        }
    }

    static void FillMatrixB(int[,] matrix, int n)
    {
        int number = 1;
        int temp = 0;
        for (int row = 0; row < n; row++)
        {
            temp = number + n - 1;
            for (int col = 0; col < n; col++)
            {
                if (row % 2 == 0)
                {
                    matrix[col, row] = number;
                }
                else
                {
                    matrix[col, row] = temp;
                    temp--;
                }
                number++;
            }
        }

    }

    static void FillMatrixA(int[,] matrix, int n)
    {
        int number = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[col, row] = number;
                number++;
            }
        }
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col] + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}