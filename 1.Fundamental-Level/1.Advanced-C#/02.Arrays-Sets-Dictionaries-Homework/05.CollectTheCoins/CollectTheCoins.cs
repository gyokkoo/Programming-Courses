using System;
using System.Data;

/*
Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
You receive the layout of a board from the console. Assume it will always have 4 rows which you'll get as
strings, each on a separate line. Each character in the strings will represent a cell on the board. 
Note that the strings may be of different length.
You are the player and start at the top-left corner (that would be position [0, 0] on the board). 
On the fifth line of input you'll receive a string with movement commands which tell you where to go next, 
it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down).
You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) 
and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). 
When all moves are over, print the amount of money collected and the number of walls hit
Input:
Sj0u$hbc
$87yihc87
Ewg3444
$4$$
V>>^^>>>VVV<<
Output:
Coins collected: 2
Walls hit: 2
 */
class CollectTheCoins
{
    const int MaxRows = 4;
    static void Main()
    {
        Console.Title = "Problem 5.	Collect the Coins";

        char[][] board = new char[MaxRows][];

        FillTheBoard(board);

        CollectCoinsAndPrintResult(board);
    }

    static void CollectCoinsAndPrintResult(char[][] board)
    {
        string commandLine = Console.ReadLine();
        int currentRow = 0;
        int currentCol = 0;

        int coinsCount = 0;
        int wallsHitCounter = 0;

        for (int i = 0; i < commandLine.Length; i++)
        {
            char direction = commandLine[i];
            if (direction == '>')
            {
                currentCol++;
                if (currentCol == board[currentRow].Length)
                {
                    currentCol--;
                    wallsHitCounter++;
                }
            }
            else if (direction == '<')
            {
                currentCol--;
                if (currentCol == -1)
                {
                    currentCol++;
                    wallsHitCounter++;
                }
            }
            else if (direction == '^')
            {
                currentRow--;
                if (currentRow == -1 || board[currentRow].Length - 1 < currentRow)
                {
                    currentRow++;
                    wallsHitCounter++;
                }
            }
            else if (direction == 'V')
            {
                currentRow++;
                if (currentRow == board[currentRow].Length ||
                    board[currentRow].Length - 1 <= currentRow)
                {
                    currentRow--;
                    wallsHitCounter++;
                }
            }

            if (board[currentRow][currentCol] == '$')
            {
                coinsCount++;
            }
        }

        Console.WriteLine("Coins collected: {0}", coinsCount);
        Console.WriteLine("Walls hit: {0}", wallsHitCounter);
    }

    static void FillTheBoard(char[][] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            char[] rowLine = Console.ReadLine().ToCharArray();
            board[i] = new char[rowLine.Length];

            for (int j = 0; j < board[i].Length; j++)
            {
                board[i][j] = rowLine[j];
            }
        }
    }
}