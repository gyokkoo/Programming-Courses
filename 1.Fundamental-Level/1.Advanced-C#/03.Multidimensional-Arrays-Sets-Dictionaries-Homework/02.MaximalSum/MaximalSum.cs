using System;
using System.Linq;
using System.Collections.Generic;
/*
Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns.
Print the elements of the 3 x 3 square as a matrix, along with their sum.
 */
class MaximalSum
{
    static void Main()
    {
        Console.Title = "Problem 2.	Maximal Sum";
        Console.WriteLine("Enter on the first line rows N and columns M and fill the matrix.");

        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = matrixSize[0];
        int columns = matrixSize[1];

        int[,] matrix = new int[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            int[] rowInut = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = rowInut[col];
            }
        }

        int maxSum = int.MinValue;
        int curSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < columns - 2; col++)
            {
                curSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (maxSum < curSum)
                {
                    maxSum = curSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Sum = {0}", maxSum);

        PrintMatrix(matrix, bestRow, bestCol);

    }
    static void PrintMatrix(int[,] matrix, int bestRow, int bestCol)
    {
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}