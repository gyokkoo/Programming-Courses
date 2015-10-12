using System;
using System.Reflection;

class SecondProblem
{
    static void Main()
    {
        string[] dimensions = Console.ReadLine().Split(' ');
        int rows = int.Parse(dimensions[0]);
        int columns = int.Parse(dimensions[1]);
        char[,] matrix = new char[rows, columns];
        FillMatrix(rows, columns, matrix);

        string commands = Console.ReadLine();

        int playerRow = 0;
        int playerCol = 0;
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (matrix[j, k] == 'P')
                {
                    playerRow = j;
                    playerCol = k;
                    matrix[j, k] = '.';
                }
            }
        }
        int i = 0;
        for (i = 0; i < commands.Length; i++)
        {
            if (commands[i] == 'U')
            {
                playerRow -= 1;
                SpreadBunnies(matrix);
                if (playerRow < 0)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", playerRow + 1, playerCol);
                    return;
                }
                if (colapseWithBunny(playerRow, playerCol, matrix))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
                    return;
                }
            }
            else if (commands[i] == 'D')
            {
                SpreadBunnies(matrix);
                playerRow += 1;
                if (playerRow >= matrix.GetLength(0))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", playerRow - 1, playerCol);
                    return;
                }

                if (colapseWithBunny(playerRow, playerCol, matrix))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
                    return;
                }

            }
            else if (commands[i] == 'R')
            {
                SpreadBunnies(matrix);
                playerCol += 1;
                if (playerCol >= matrix.GetLength(1))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", playerRow, playerCol - 1);
                    return;
                }
                if (colapseWithBunny(playerRow, playerCol, matrix))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
                    return;
                }
            }
            else if (commands[i] == 'L')
            {
                SpreadBunnies(matrix);
                playerCol -= 1;
                if (playerCol < 0)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("won: {0} {1}", playerRow, playerCol + 1);
                    return;
                }
                if (colapseWithBunny(playerRow, playerCol, matrix))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", playerRow, playerCol);
                    return;
                }
            }


        }


        //for (int j = i; j < commands.Length; j++)
        //{
        //    SpreadBunnies(matrixOne);
        //    UpperCaseMatrix(matrixOne);
        //}
    }



    private static bool colapseWithBunny(int row, int col, char[,] matrix)
    {
        bool isColapsed = false;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 'B')
                {
                    if (i == row && j == col)
                    {
                        matrix[row, col] = 'B';
                        isColapsed = true;
                    }
                }
            }
        }
        return isColapsed;
    }


    private static void SpreadBunnies(char[,] matrixOne)
    {
        char[,] matrixTwo = new char[matrixOne.GetLength(0), matrixOne.GetLength(1)];
        for (int j = 0; j < matrixOne.GetLength(0); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrixTwo[j, k] = matrixOne[j, k];
            }
        }

        for (int row = 0; row < matrixOne.GetLength(0); row++)
        {
            for (int col = 0; col < matrixOne.GetLength(1); col++)
            {
                if (matrixOne[row, col] == 'B')
                {
                    if (row - 1 >= 0)
                        matrixTwo[row - 1, col] = 'B';
                    if (col - 1 >= 0)
                        matrixTwo[row, col - 1] = 'B';
                    if (col + 1 < matrixOne.GetLength(1))
                        matrixTwo[row, col + 1] = 'B';
                    if (row + 1 < matrixOne.GetLength(0))
                        matrixTwo[row + 1, col] = 'B';
                }
            }
        }

        for (int j = 0; j < matrixOne.GetLength(0); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrixOne[j, k] = matrixTwo[j, k];
            }
        }
    }

    private static void FillMatrix(int rows, int columns, char[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            string line = Console.ReadLine();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = line[col];
            }
        }
    }

    private static void PrintMatrix(char[,] matrix)
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
}
