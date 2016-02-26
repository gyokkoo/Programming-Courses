namespace _2.TargetPractice
{
    using System;

    public class TargetPractice
    {
        public static void Main()
        {
            string[] dimensions = Console.ReadLine().Split();
            string snakeString = Console.ReadLine();
            string[] shotParams = Console.ReadLine().Split();

            int rows = int.Parse(dimensions[0]);
            int columns = int.Parse(dimensions[1]);

            int impactRow = int.Parse(shotParams[0]);
            int impactColumn = int.Parse(shotParams[1]);
            int radius = int.Parse(shotParams[2]);

            char[,] matrix = new char[rows, columns];

            FillZigZagMatrix(matrix, snakeString);

            FireAShot(matrix, impactRow, impactColumn, radius);

            DropCharacters(matrix);

            PrintMatrix(matrix);
        }

        private static void DropCharacters(char[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
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

        private static void FireAShot(char[,] matrix, int impactX, int impactY, int radius)
        {
            matrix[impactX, impactY] = ' ';

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    try
                    {
                        int deltaX = x - impactX;
                        int deltaY = y - impactY;
                        if ((deltaX * deltaX) + (deltaY * deltaY) <= radius * radius)
                        {
                            matrix[x, y] = ' ';
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // ignored
                    }
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

        private static void FillZigZagMatrix(char[,] matrix, string snakeString)
        {
            int maxRow = matrix.GetLength(0);
            int maxColumn = matrix.GetLength(1);
            int row = maxRow - 1;
            int col = maxColumn - 1;
            string direction = "left";
            int snakeIndex = 0;
            int cellCounter = 0;
            matrix[row, col] = snakeString[0];
            while (cellCounter < maxRow * maxColumn)
            {
                char currentLetter = snakeString[snakeIndex = snakeIndex == snakeString.Length ? 0 : snakeIndex];
                matrix[row, col] = currentLetter;

                if (direction == "left")
                {
                    if (col - 1 >= 0)
                    {
                        col--;
                    }
                    else
                    {
                        row--;
                        direction = "right";
                    }
                }
                else if (direction == "right")
                {
                    if (col + 1 < maxColumn)
                    {
                        col++;
                    }
                    else
                    {
                        row--;
                        direction = "left";
                    }
                }

                cellCounter++;
                snakeIndex++;
            }
        }
    }
}
