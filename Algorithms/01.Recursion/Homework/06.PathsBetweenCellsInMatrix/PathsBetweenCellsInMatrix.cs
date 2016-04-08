namespace _06.PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class PathsBetweenCellsInMatrix
    {
        private static readonly string[,] Labyrinth =
            {
                { "s", " ", " ", " " },
                { " ", "*", "*", " " },
                { " ", "*", "*", " " },
                { " ", "*", "e", " " },
                { " ", " ", " ", " " }
            };

        // Ctrl + K + U Uncomment
        // Ctrl + K + C Comment

        //private static readonly string[,] Labyrinth =
        //    {
        //        { "s", " ", " ", " ", " ", " " },
        //        { " ", "*", "*", " ", "*", " " },
        //        { " ", "*", "*", " ", "*", " " },
        //        { " ", "*", "e", " ", " ", " " },
        //        { " ", " ", " ", "*", " ", " " }
        //    };

        private const string StartCell = "s";
        private const string ExitCell = "e";
        private const string PassableCell = " ";
        private const string AlreadyPassedCell = ".";

        private static readonly List<string> Steps = new List<string>();
        private static int foundPaths;
        
        public static void Main()
        {
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < Labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < Labyrinth.GetLength(1); col++)
                {
                    if (Labyrinth[row, col] == StartCell)
                    {
                        startRow = row;
                        startCol = col;
                        Labyrinth[row, col] = PassableCell;
                        break;
                    }
                }
            }

            FindPathToExit(startRow, startCol, string.Empty);
            Console.WriteLine("Total paths found: {0}", foundPaths);
        }

        private static void FindPathToExit(int row, int col, string direction)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (Labyrinth[row, col] == ExitCell)
            {
                foundPaths++;
                Console.WriteLine(string.Join(string.Empty, Steps) + direction);
            }

            if (Labyrinth[row, col] != PassableCell)
            {
                return;
            }

            Steps.Add(direction);
            Labyrinth[row, col] = AlreadyPassedCell;

            FindPathToExit(row, col - 1, "L");
            FindPathToExit(row, col + 1, "R");
            FindPathToExit(row - 1, col, "U");
            FindPathToExit(row + 1, col, "D");

            Steps.RemoveAt(Steps.Count - 1);
            Labyrinth[row, col] = PassableCell;
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = 0 <= row && row < Labyrinth.GetLength(0);
            bool colInRange = 0 <= col && col < Labyrinth.GetLength(1);

            return rowInRange && colInRange;
        }
    }
}