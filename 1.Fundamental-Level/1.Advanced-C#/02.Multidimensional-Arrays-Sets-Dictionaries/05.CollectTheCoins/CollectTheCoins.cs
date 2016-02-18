namespace _05.CollectTheCoins
{
    using System;

    public class CollectTheCoins
    {
        public static void Main()
        {
            const int Rows = 4;
            char[][] board = new char[Rows][];

            FillBoard(board);

            char[] commandArgs = Console.ReadLine().ToCharArray();

            int row = 0;
            int col = 0;
            int collectedCoins = 0;
            int wallsHit = 0;
            foreach (char command in commandArgs)
            {
                switch (command)
                {
                    case '>':
                        if (col + 1 == board[row].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            col++;
                        }

                        if (board[row][col] == '$')
                        {
                            collectedCoins++;
                            board[row][col] = ' ';
                        }

                        break;
                    case '<':
                        if (col - 1 < 0)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            col--;
                        }

                        if (board[row][col] == '$')
                        {
                            collectedCoins++;
                            board[row][col] = ' ';
                        }

                        break;
                    case '^':
                        if (row - 1 < 0 || col >= board[row - 1].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            row--;
                        }

                        if (board[row][col] == '$')
                        {
                            collectedCoins++;
                            board[row][col] = ' ';
                        }

                        break;
                    case 'V':
                        if (row + 1 == Rows || col >= board[row + 1].Length)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            row++;
                        }

                        if (board[row][col] == '$')
                        {
                            collectedCoins++;
                            board[row][col] = ' ';
                        }

                        break;
                    default:
                        throw new InvalidOperationException("Invalid command.");
                }
            }

            Console.WriteLine("Coins collected: " + collectedCoins);
            Console.WriteLine("Walls hit: " + wallsHit);
        }

        private static void FillBoard(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                string line = Console.ReadLine();
                board[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    board[row][col] = line[col];
                }
            }
        }
    }
}