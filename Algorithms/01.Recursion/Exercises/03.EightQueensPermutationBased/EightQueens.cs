namespace _03.EightQueensPermutationBased
{
    using System;

    public class EightQueens
    {
        private const int Size = 8;
        private static readonly int[] Board = new int[Size];

        private static int solutionsFound;

        public static void Main()
        {
            PutQueens(0);
            Console.WriteLine(solutionsFound);
        }

        private static void PutQueens(int n)
        {
            if (n == Board.Length)
            {
                PrintQueens();
                solutionsFound++;
            }
            else
            {
                for (int i = 0; i < Size; i++)
                {
                    Board[n] = i;
                    if (IsConsistent(n))
                    {
                        PutQueens(n + 1);
                    }
                }
            }
        }

        private static bool IsConsistent(int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool columnCheck = Board[i] == Board[n];
                bool majorDiagonalCheck = Board[i] - Board[n] == n - i;
                bool minorDiagonalCheck = Board[n] - Board[i] == n - i;

                if (columnCheck || majorDiagonalCheck || minorDiagonalCheck)
                {
                    return false;
                }
            }

            return true;
        }

        private static void PrintQueens()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write(Board[i] == j ? "*" : "-");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}