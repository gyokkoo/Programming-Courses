namespace _11.StringMatrixRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatrixRotation
    {
        public static void Main()
        {
            string[] command = Console.ReadLine().TrimEnd(')').Split('(');
            int rotation = int.Parse(command[1]) % 360;

            List<string> inputLists = new List<string>();
            string line = Console.ReadLine();

            while (line != "END")
            {
                inputLists.Add(line);

                line = Console.ReadLine();
            }

            string[,] matrix = CreateMatrix(inputLists);

            switch (rotation)
            {
                case 0:
                    PrintMatrix(matrix);
                    break; ;
                case 90:
                    PrintRotate90(matrix);
                    break;
                case 180:
                    Rotate180(matrix);
                    break;
                case 270:
                    Rotate270(matrix);
                    break;
                default:
                    throw new InvalidOperationException("Invalid command.");
            }
        }

        private static void Rotate270(string[,] matrix)
        {
            for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[col, row]);
                }
                Console.WriteLine();
            }
        }

        private static void Rotate180(string[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void PrintRotate90(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[col, row]);
                }

                Console.WriteLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static string[,] CreateMatrix(List<string> inputLists)
        {
            int rows = inputLists.Count;
            int columns = inputLists.Max(x => x.Length);

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = inputLists[row].PadRight(columns, ' ')[col].ToString();
                }
            }

            return matrix;
        }
    }
}