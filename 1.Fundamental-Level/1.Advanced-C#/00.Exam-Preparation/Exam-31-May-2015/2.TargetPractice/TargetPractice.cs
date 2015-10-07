using System;

class TargetPractice
{
    static void Main()
    {
        string[] matrixDimensions = Console.ReadLine().Split();
        string snake = Console.ReadLine();
        string[] shotParameters = Console.ReadLine().Split();

        int rows = int.Parse(matrixDimensions[0]);
        int columns = int.Parse(matrixDimensions[1]);

        int targetRow = int.Parse(shotParameters[0]);
        int targetCol = int.Parse(shotParameters[1]);
        int shotRadius = int.Parse(shotParameters[2]);

        char[,] matrix = new char[rows, columns];

        FillMatrix(matrix, snake, rows, columns);

        FireAShot(matrix, targetRow, targetCol, shotRadius);

        DropCharacters(matrix);

        PrintMatrix(matrix);
    }

    static void FillMatrix(char[,] matrix, string snake, int numberOfRows, int numberOfColumns)
    {
        string direction = "left";
        int snakeChRemainder = 0;
        for (int row = numberOfRows - 1; row >= 0; row--)
        {
            if (direction == "left")
            {
                for (int col = numberOfColumns - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[(numberOfColumns - col - 1 + snakeChRemainder) % snake.Length];
                }
                snakeChRemainder += numberOfColumns % snake.Length;
                direction = "right";

            }
            else if (direction == "right")
            {
                for (int col = 0; col < numberOfColumns; col++)
                {
                    matrix[row, col] = snake[(col + snakeChRemainder) % snake.Length];
                }
                snakeChRemainder += numberOfColumns % snake.Length;
                direction = "left";
            }
        }
    }

    static void FireAShot(char[,] matrix, int targetRow, int targetCol, int shotRadius)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (isInsideRadius(row, col, targetRow, targetCol, shotRadius))
                {
                    matrix[row, col] = ' ';
                }
            }
        }
    }

    static bool isInsideRadius(int currentRow, int currentCol, int targetRow, int targetCol, int shotRadius)
    {
        int deltaRow = currentRow - targetRow;
        int deltaCol = currentCol - targetCol;

        bool isInsideRadius = deltaRow * deltaRow + deltaCol * deltaCol
                              <= shotRadius * shotRadius;

        return isInsideRadius;
    }

    static void DropCharacters(char[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == ' ')
                {
                    for (int i = row - 1; i >= 0; i--)
                    {
                        if (matrix[i, col] != ' ')
                        {
                            matrix[row, col] = matrix[i, col];
                            matrix[i, col] = ' ';
                            break;
                        }
                    }
                }
            }
        }
    }

    static void PrintMatrix(char[,] matrix)
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