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

        //TODO
    }



    static void FillMatrix(char[,] matrix, string snake, int numberOfRows, int numberOfColumns)
    {
        string direction = "right";
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
        //TODO
    }
}
    















     



        for (int row = rows - 1; row >= 0; row--)
        {
            for (int col = 0; col < columns; col++)
            {
               if(matrix[row, col] == ' ')
               {
                   for (int i = rows - 1; i >= 0; i--)
                   {
                       if(matrix[i, col] != ' ')
                       {
                           matrix[row, col] = matrix[i, col];
                           matrix[i, col] = ' ';
                           break;
                       }
                   }
               }
            }
        }


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}