namespace _02.EightQueensPuzle
{
    using System;

    public class EightQueens
    {
        private const int Size = 8;
        private static readonly bool[,] Chessboard = new bool[Size, Size];

        private static readonly bool[] AttackedColumns = new bool[Size];
        private static readonly bool[] AttackedLeftDiagonal = new bool[(Size * 2) - 1];
        private static readonly bool[] AttackedRightDiagonal = new bool[(Size * 2) - 1];

        private static int solutionsFound;

        public static void Main(string[] args)
        {
            PutQueens(0);
            Console.WriteLine(solutionsFound);
        }

        private static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnMarlAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied = AttackedColumns[col] || AttackedLeftDiagonal[col - row + Size - 1]
                                   || AttackedRightDiagonal[row + col];

            return !positionOccupied;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            AttackedColumns[col] = true;
            AttackedLeftDiagonal[col - row + Size - 1] = true;
            AttackedRightDiagonal[row + col] = true;
            Chessboard[row, col] = true;
        }

        private static void UnMarlAllAttackedPositions(int row, int col)
        {
            AttackedColumns[col] = false;
            AttackedLeftDiagonal[col - row + Size - 1] = false;
            AttackedRightDiagonal[row + col] = false;
            Chessboard[row, col] = false;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    Console.Write(Chessboard[row, col] ? "*" : "-");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            solutionsFound++;
        }
    }
}