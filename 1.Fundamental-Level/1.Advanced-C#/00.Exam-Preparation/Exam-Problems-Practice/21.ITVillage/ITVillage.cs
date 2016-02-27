namespace _21.ITVillage
{
    using System;
    using System.Linq;

    public class ItVillage
    {
        private const int Rows = 4;
        private const int Columns = 4;

        public static void Main()
        {
            string[,] board = new string[Rows, Columns];
            string[] boardInfo = Console.ReadLine().Trim().Replace(" | ", " ").Split();
            string[] startCoordinates = Console.ReadLine().Split();
            int[] diceNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startRow = int.Parse(startCoordinates[0]) - 1;
            int startColumn = int.Parse(startCoordinates[1]) - 1;
            int currentRow = startRow;
            int currentCol = startColumn;

            int coins = 50;

            FillBoard(board, boardInfo);

            string gameResult = GetGameResult(diceNumbers, board, currentRow, currentCol, coins);

            Console.WriteLine($"<p>{gameResult}<p>");
        }

        private static string GetGameResult(int[] diceNumbers, string[,] board, int currentRow, int currentCol, int coins)
        {
            int innCount = 0;

            for (int i = 0; i < diceNumbers.Length; i++)
            {
                coins += innCount * 20;

                int diceNumber = diceNumbers[i] % 12;

                string fieldLetter = GetNextFieldLetter(diceNumber, board, ref currentRow, ref currentCol);

                switch (fieldLetter)
                {
                    case "P":
                        coins -= 5;
                        break;
                    case "I":
                        if (coins < 100)
                        {
                            coins -= 10;
                        }
                        else
                        {
                            coins -= 100;
                            board[currentRow, currentCol] = "Home";
                            innCount++;
                        }
                        break;
                    case "F":
                        coins += 20;
                        break;
                    case "S":
                        i += 2;
                        coins -= 2 * innCount * 20;
                        break;
                    case "V":
                        coins *= 10;
                        break;
                    case "Home":
                        break;
                    case "N":
                        return "You won! Nakov's force was with you!";
                    default:
                        throw new ArgumentException("Invalid field!");
                }

                if (HasBoughtAllInns(board))
                {
                    return $"You won! You own the village now! You have {coins} coins!";
                }

                if (coins < 0)
                {
                    return "You lost! You ran out of money!";
                }
            }


            return $"You lost! No more moves! You have {coins} coins!";
        }

        private static bool HasBoughtAllInns(string[,] board)
        {
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    if (board[row, col] == "I")
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static string GetNextFieldLetter(int diceNumber, string[,] board, ref int currentRow, ref int currentCol)
        {
            while (diceNumber != 0)
            {
                if (currentRow == 0 && currentCol + 1 < Columns)
                {
                    currentCol++;
                }
                else if (currentCol == Columns - 1 && currentRow + 1 < Rows)
                {
                    currentRow++;
                }
                else if (currentRow == Rows - 1 && currentCol - 1 >= 0)
                {
                    currentCol--;
                }
                else if (currentCol == 0 && currentRow - 1 >= 0)
                {
                    currentRow--;
                }

                diceNumber--;
            }

            string letter = board[currentRow, currentCol];
            return letter;
        }

        private static void FillBoard(string[,] board, string[] boardInfo)
        {
            int index = 0;
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    board[row, col] = boardInfo[index];
                    index++;
                }
            }
        }
    }
}
