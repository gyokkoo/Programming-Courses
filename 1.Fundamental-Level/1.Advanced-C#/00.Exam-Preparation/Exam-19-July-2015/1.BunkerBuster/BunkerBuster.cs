using System;

class BunkerBuster
{
    static void Main()
    {
        string[] matrixSize = Console.ReadLine().Split();
        int rows = int.Parse(matrixSize[0]);
        int columns = int.Parse(matrixSize[1]);
        int[,] bombField = new int[rows, columns];

        FillMatrix(rows, columns, bombField);

        string[] command = Console.ReadLine().Split();
        while ((command[0] + " " + command[1]) != "cease fire!")
        {
            int targetRow = int.Parse(command[0]);
            int targetCol = int.Parse(command[1]);
            int bombPower = command[2].ToCharArray()[0];

            BombExplode(targetRow, targetCol, bombPower, bombField);
            command = Console.ReadLine().Split();
        }

        int destroyedCellsCount = CountDestroyedCells(bombField);
        int allCells = rows * columns;

        Console.WriteLine("Destroyed bunkers: {0}", destroyedCellsCount);
        Console.WriteLine("Damage done: {0:F1} %", (double)destroyedCellsCount / allCells * 100);

        //PrintMatrix(rows, columns, bombField);
    }

    private static void PrintMatrix(int rows, int columns, int[,] bombField)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(bombField[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static int CountDestroyedCells(int[,] bombField)
    {
        int counter = 0;
        for (int row = 0; row < bombField.GetLength(0); row++)
        {
            for (int col = 0; col < bombField.GetLength(1); col++)
            {
                if (bombField[row, col] <= 0)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    private static void BombExplode(int targetRow, int targetCol, int bombPower, int[,] bombField)
    {
        bombField[targetRow, targetCol] -= bombPower;
        int adjacentDamage = (int)(Math.Ceiling(bombPower / 2.0));
        if (targetRow - 1 >= 0 && targetCol - 1 >= 0)
            bombField[targetRow - 1, targetCol - 1] -= adjacentDamage;
        if (targetRow - 1 >= 0)
            bombField[targetRow - 1, targetCol] -= adjacentDamage;
        if (targetRow - 1 >= 0 && targetCol + 1 < bombField.GetLength(1))
            bombField[targetRow - 1, targetCol + 1] -= adjacentDamage;
        if (targetCol - 1 >= 0)
            bombField[targetRow, targetCol - 1] -= adjacentDamage;
        if (targetCol + 1 < bombField.GetLength(1))
            bombField[targetRow, targetCol + 1] -= adjacentDamage;
        if (targetRow + 1 < bombField.GetLength(0) && targetCol - 1 >= 0)
            bombField[targetRow + 1, targetCol - 1] -= adjacentDamage;
        if (targetRow + 1 < bombField.GetLength(0))
            bombField[targetRow + 1, targetCol] -= adjacentDamage;
        if (targetRow + 1 < bombField.GetLength(0) && targetCol + 1 < bombField.GetLength(1))
            bombField[targetRow + 1, targetCol + 1] -= adjacentDamage;
    }

    private static void FillMatrix(int rows, int columns, int[,] bombField)
    {
        for (int row = 0; row < rows; row++)
        {
            string[] numbers = Console.ReadLine().Split();
            for (int col = 0; col < columns; col++)
            {
                bombField[row, col] = int.Parse(numbers[col]);
            }
        }
    }
}