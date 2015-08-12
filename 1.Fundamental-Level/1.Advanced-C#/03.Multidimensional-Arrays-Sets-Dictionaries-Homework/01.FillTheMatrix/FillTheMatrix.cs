using System;
/*
Write two programs that fill and print a matrix of size N x N. 
Filling a matrix in the regular pattern (top to bottom and left to right) is boring. 
Fill the matrix as described in both patterns below: 
 */
class FillTheMatrix
{
    static void Main()
    {
        Console.Title = "Problem 1.	Fill the Matrix";

        Console.Write("N = ");
        int sizeN = int.Parse(Console.ReadLine());

        int[,] matrix = new int[sizeN, sizeN];
        int number = 1;
        for (int col = 0; col < sizeN; col++)
        {
            for (int row = 0; row < sizeN; row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }
        PrintMatrix(matrix);

        number = 1;
        for (int col = 0; col < sizeN; col++)
        {
            for (int row = 0; row < sizeN; row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = number;
                    number++;
                }
                else
                {
                    int newRow = sizeN - row - 1;
                    matrix[newRow, col] = number;
                    number++;
                }
            }
        }
        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
