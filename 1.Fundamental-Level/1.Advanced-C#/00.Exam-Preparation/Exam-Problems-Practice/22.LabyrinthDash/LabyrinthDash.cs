namespace _22.LabyrinthDash
{
    using System;

    public class LabyrinthDash
    {
        public static void Main()
        {
            const string ObstacleCharacters = "*#@";
            int numbersOfRows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[numbersOfRows][];

            for (int i = 0; i < numbersOfRows; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            string commands = Console.ReadLine();
            int livesLeft = 3;
            int row = 0;
            int col = 0;
            int movesMade = 0;

            foreach (var direction in commands)
            {
                int previousRow = row;
                int previousCol = col;
                switch (direction)
                {
                    case '<':
                        col--;
                        break;
                    case '>':
                        col++;
                        break;
                    case 'v':
                        row++;
                        break;
                    case '^':
                        row--;
                        break;
                }

                if (!IsCellInsideMatrix(row, col, matrix) || matrix[row][col] == ' ')
                {
                    Console.WriteLine("Fell off a cliff! Game Over!");
                    movesMade++;
                    break;
                }

                if (matrix[row][col] == '_' || matrix[row][col] == '|')
                {
                    Console.WriteLine("Bumped a wall.");
                    row = previousRow;
                    col = previousCol;
                }
                else if (ObstacleCharacters.Contains(matrix[row][col].ToString()))
                {
                    livesLeft--;
                    movesMade++;
                    Console.WriteLine("Ouch! That hurt! Lives left: {0}", livesLeft);
                    if (livesLeft <= 0)
                    {
                        Console.WriteLine("No lives left! Game Over!");
                        break;
                    }
                }
                else if (matrix[row][col] == '$')
                {
                    livesLeft++;
                    movesMade++;
                    matrix[row][col] = '.';
                    Console.WriteLine("Awesome! Lives left: {0}", livesLeft);
                }
                else
                {
                    movesMade++;
                    Console.WriteLine("Made a move!");
                }
            }

            Console.WriteLine("Total moves made: {0}", movesMade);
        }

        private static bool IsCellInsideMatrix(int row, int col, char[][] matrix)
        {
            bool isRowInsideMatrix = 0 <= row && row < matrix.Length;

            if (!isRowInsideMatrix)
            {
                return false;
            }

            bool isColInRange = 0 <= col && col < matrix[row].Length;

            return isColInRange;
        }
    }
}