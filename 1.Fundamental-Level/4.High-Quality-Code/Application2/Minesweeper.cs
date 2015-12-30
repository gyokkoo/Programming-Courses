namespace Application2
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        private const int MaxRounds = 35;

        private static void Main()
        {
            Console.Title = "Consoled Minesweeper 3000";

            List<Score> scores = new List<Score>(6);
            string command = string.Empty;
            char[,] board = CreateGameField();
            char[,] bombs = SetRandomBombs();
            int roundCounter = 0;
            bool isBombed = false;
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool isGameBeat = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper. Try your luck to find all hidden mines without detonating any of them.");
                    Console.WriteLine("Command 'top' shows the scores");
                    Console.WriteLine("Command 'restart' starts a new game");
                    Console.WriteLine("Command 'exit' exits from the game");
                    PrintField(board);
                    isNewGame = false;
                }

                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ExecuteTopCommand(scores);
                        break;
                    case "restart":
                        board = CreateGameField();
                        bombs = SetRandomBombs();
                        PrintField(board);
                        isBombed = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                ExecuteRound(board, bombs, row, col);
                                roundCounter++;
                            }

                            if (MaxRounds == roundCounter)
                            {
                                isGameBeat = true;
                            }
                            else
                            {
                                PrintField(board);
                            }
                        }
                        else
                        {
                            isBombed = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nUnknown command.\n");
                        break;
                }

                if (isBombed)
                {
                    PrintField(bombs);
                    Console.WriteLine($"\nHrrrrrr! You died with {roundCounter} points.");
                    Console.Write("Ener your nickname: ");
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, roundCounter);
                    if (scores.Count < 5)
                    {
                        scores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < scores.Count; i++)
                        {
                            if (scores[i].Points < score.Points)
                            {
                                scores.Insert(i, score);
                                scores.RemoveAt(scores.Count - 1);
                                break;
                            }
                        }
                    }

                    scores.Sort((r1, r2) => r2.Name.CompareTo(r1.Name));
                    scores.Sort((r1, r2) => r2.Points.CompareTo(r1.Points));

                    ExecuteTopCommand(scores);

                    board = CreateGameField();
                    bombs = SetRandomBombs();
                    roundCounter = 0;
                    isBombed = false;
                    isNewGame = true;
                }

                if (isGameBeat)
                {
                    Console.WriteLine("\nBRAVOOOS! You won the game!!! CONGRATULATIONS !");
                    PrintField(bombs);
                    Console.WriteLine("Dude i must know your name: ");
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, roundCounter);
                    scores.Add(score);
                    ExecuteTopCommand(scores);
                    board = CreateGameField();
                    bombs = SetRandomBombs();
                    roundCounter = 0;
                    isGameBeat = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("Have a nice day...");
            Console.Read();
        }

        private static void ExecuteTopCommand(List<Score> points)
        {
            Console.WriteLine("\nPOINTS:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty ranglist!\n");
            }
        }

        private static void ExecuteRound(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsCount = GetBombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            field[row, col] = bombsCount;
        }

        private static void PrintField(char[,] board)
        {
            int maxRows = board.GetLength(0);
            int maxColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < maxRows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < maxColumns; col++)
                {
                    Console.Write("{0} ", board[row, col]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetRandomBombs()
        {
            int maxRows = 5;
            int maxColumns = 10;
            char[,] board = new char[maxRows, maxColumns];

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxColumns; col++)
                {
                    board[row, col] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int col = number / maxColumns;
                int row = number % maxColumns;
                if (row == 0 && number != 0)
                {
                    col--;
                    row = maxColumns;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static char GetBombsCount(char[,] field, int row, int col)
        {
            int bombsCount = 0;
            int maxRows = field.GetLength(0);
            int maxColumns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (row + 1 < maxRows)
            {
                if (field[row + 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if (col + 1 < maxColumns)
            {
                if (field[row, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < maxColumns))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < maxRows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < maxRows) && (col + 1 < maxColumns))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            return char.Parse(bombsCount.ToString());
        }
    }
}