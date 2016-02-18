namespace _03.MatrixShuffling
{
    using System;

    public class MatrixShuffling
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] lineParams = line.Split();
                if (IsValidCommand(lineParams, matrix))
                {
                    int row1 = int.Parse(lineParams[1]);
                    int col1 = int.Parse(lineParams[2]);
                    int row2 = int.Parse(lineParams[3]);
                    int col2 = int.Parse(lineParams[4]);

                    PerformSwapOperation(row1, col1, row2, col2, matrix);

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                line = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void PerformSwapOperation(int row1, int col1, int row2, int col2, string[,] matrix)
        {
            string swapValue = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = swapValue;
        }

        private static bool IsValidCommand(string[] lineParams, string[,] matrix)
        {
            if (lineParams[0] != "swap" || lineParams.Length != 5)
            {
                return false;
            }

            int row1 = int.Parse(lineParams[1]);
            int col1 = int.Parse(lineParams[2]);
            int row2 = int.Parse(lineParams[3]);
            int col2 = int.Parse(lineParams[4]);

            if (row1 < 0 || matrix.GetLength(0) < row1 || row2 < 0 || matrix.GetLength(0) < row2 || 
                col1 < 0 || matrix.GetLength(1) < col1 || col2 < 0 || matrix.GetLength(1) < col2)
            {
                return false;
            }

            return true;
        }
    }
}