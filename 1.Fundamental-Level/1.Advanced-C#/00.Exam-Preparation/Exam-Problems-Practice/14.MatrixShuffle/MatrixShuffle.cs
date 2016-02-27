namespace _14.MatrixShuffle
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class MatrixShuffle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            char[,] matrix = new char[n, n];

            FillSpiralMatrix(matrix, text);

            string resultText = GetTextResult(matrix);
            if (IsPalindrome(resultText))
            {
                Console.WriteLine($"<div style='background-color:#4FE000'>{resultText}</div>");
            }
            else
            {
                Console.WriteLine($"<div style='background-color:#E0000F'>{resultText}</div>");
            }
        }

        private static bool IsPalindrome(string resultText)
        {
            resultText = Regex.Replace(resultText, @"[^a-zA-Z]", string.Empty).ToLower();
            var reversedText = resultText.Reverse().ToArray();
            for (int i = 0; i < resultText.Length; i++)
            {
                if (resultText[i] != reversedText[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetTextResult(char[,] matrix)
        {
            StringBuilder whiteSquares = new StringBuilder();
            StringBuilder blackSquares = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        whiteSquares.Append(matrix[row, col]);
                    }
                    else
                    {
                        blackSquares.Append(matrix[row, col]);
                    }
                }
            }

            return whiteSquares.ToString() + blackSquares;
        }

        private static void FillSpiralMatrix(char[,] matrix, string text)
        {
            int n = matrix.GetLength(0);
            int row = 0;
            int col = 0;
            string direction = "right";
            int index = 0;
            while (index < n * n)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != '\0'))
                {
                    direction = "down";
                    col--;
                    row++;
                }

                if (direction == "down" && (row > n - 1 || matrix[row, col] != '\0'))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != '\0'))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != '\0'))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = index < text.Length ? text[index] : ' ';
                index++;

                if (direction == "right")
                {
                    col++;
                }

                if (direction == "down")
                {
                    row++;
                }

                if (direction == "left")
                {
                    col--;
                }

                if (direction == "up")
                {
                    row--;
                }
            }
        }
    }
}