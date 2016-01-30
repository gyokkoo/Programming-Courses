namespace RotatingWalkInMatrix
{
    using System;

    public class WalkInMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateMatrix(n);

            PrintMatrix(matrix);
        }

        public static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int currentNumber = 1;
            int x = 0;
            int y = 0;
            int dirX = 1;
            int dirY = 1;

            while (currentNumber <= n * n)
            {
                matrix[x, y] = currentNumber;

                if (AdjacentCellsNotEmpty(matrix, x, y))
                {
                    SetPositionToEmptyCell(matrix, out x, out y);
                    dirX = 1;
                    dirY = 1;
                    currentNumber++;
                    continue;
                }

                while (x + dirX >= n || x + dirX < 0 || y + dirY >= n || y + dirY < 0 || matrix[x + dirX, y + dirY] != 0)
                {
                    ChangeDirection(ref dirX, ref dirY);
                }

                x += dirX;
                y += dirY;
                currentNumber++;
            }

            return matrix;
        }

        private static void ChangeDirection(ref int dX, ref int dY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirectionIndex = 0;
            for (int count = 0; count < 8; count++)
            {
                if (directionsX[count] == dX && directionsY[count] == dY)
                {
                    currentDirectionIndex = count;
                    break;
                }
            }

            if (currentDirectionIndex == 7)
            {
                dX = directionsX[0];
                dY = directionsY[0];
            }
            else
            {
                dX = directionsX[currentDirectionIndex + 1];
                dY = directionsY[currentDirectionIndex + 1];
            }
        }

        private static bool AdjacentCellsNotEmpty(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(1) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void SetPositionToEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    if (arr[row, col] == 0)
                    {
                        x = row;
                        y = col;
                        return;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}