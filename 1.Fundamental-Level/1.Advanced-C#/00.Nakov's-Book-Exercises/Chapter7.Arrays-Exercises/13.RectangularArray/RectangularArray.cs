using System;
/*
Write a program, which creates a rectangular array with size of n by m elements. 
The dimensions and the elements should be read from the console. 
Find a platform with size of (3, 3) with a maximal sum.
 */
class RectangularArray
{
    static void Main()
    {
        int[,] matrix = {
        { 0, 2, 4, 0, 9, 5 },
        { 7, 1, 3, 3, 2, 1 },
        { 1, 3, 9, 8, 5, 6 },
        { 4, 6, 7, 9, 1, 0 }
        };

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("The best platform is:");
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}