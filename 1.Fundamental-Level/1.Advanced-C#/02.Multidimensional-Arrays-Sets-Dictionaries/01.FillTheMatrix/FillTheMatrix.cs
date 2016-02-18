namespace _01.FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[n, n];
            int number = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixA[row, col] = number++;
                }
            }

            PrintMatrix(matrixA);

            int[,] matrixB = new int[n, n];
            number = 1;
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (col % 2 == 0)
                    {
                        matrixB[row, col] = number++;
                    }
                    else
                    {
                        int newRow = n - row - 1;
                        matrixB[newRow, col] = number++;
                    }
                }
            }

            PrintMatrix(matrixB);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}