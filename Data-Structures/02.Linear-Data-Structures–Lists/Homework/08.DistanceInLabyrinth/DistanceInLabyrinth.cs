namespace _08.DistanceInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public class DistanceInLabyrinth
    {
        private const string StartPositionSymbol = "*";
        private const string EmptyCellSymbol = "0";
        private const string UnreachbleCellSymbol = "u";

        private static readonly string[,] Matrix =
        {
            { "0", "0", "0", "x", "0", "x" },
            { "0", "x", "0", "x", "0", "x" },
            { "0", "*", "x", "0", "x", "0" },
            { "0", "x", "0", "0", "0", "0" },
            { "0", "0", "0", "x", "x", "0" },
            { "0", "0", "0", "x", "0", "x" }
        };

        public static void Main()
        {
            int row = 0;
            int col = 0;

            GetStarCoordinates(ref row, ref col);

            var queue = new Queue<Cell>();
            queue.Enqueue(new Cell(row, col, 0));

            while (queue.Count > 0)
            {
                var currentCell = queue.Dequeue();
                if (currentCell.Row > 0 &&
                    Matrix[currentCell.Row - 1, currentCell.Col] == EmptyCellSymbol)
                {
                    queue.Enqueue(new Cell(currentCell.Row - 1, currentCell.Col, currentCell.Step + 1));
                    Matrix[currentCell.Row - 1, currentCell.Col] = (currentCell.Step + 1).ToString();
                }

                if (currentCell.Col < Matrix.GetLength(1) - 1 &&
                    Matrix[currentCell.Row, currentCell.Col + 1] == EmptyCellSymbol)
                {
                    queue.Enqueue(new Cell(currentCell.Row, currentCell.Col + 1, currentCell.Step + 1));
                    Matrix[currentCell.Row, currentCell.Col + 1] = (currentCell.Step + 1).ToString();
                }

                if (currentCell.Row < Matrix.GetLength(0) - 1 &&
                    Matrix[currentCell.Row + 1, currentCell.Col] == EmptyCellSymbol)
                {
                    queue.Enqueue(new Cell(currentCell.Row + 1, currentCell.Col, currentCell.Step + 1));
                    Matrix[currentCell.Row + 1, currentCell.Col] = (currentCell.Step + 1).ToString();
                }

                if (currentCell.Col > 0 &&
                    Matrix[currentCell.Row, currentCell.Col - 1] == EmptyCellSymbol)
                {
                    queue.Enqueue(new Cell(currentCell.Row, currentCell.Col - 1, currentCell.Step + 1));
                    Matrix[currentCell.Row, currentCell.Col - 1] = (currentCell.Step + 1).ToString();
                }
            }

            PrintMatrix();
        }

        private static void GetStarCoordinates(ref int row, ref int col)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == StartPositionSymbol)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Matrix[row, col] = Matrix[row, col] == EmptyCellSymbol ? UnreachbleCellSymbol : Matrix[row, col];
                    Console.Write(Matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}