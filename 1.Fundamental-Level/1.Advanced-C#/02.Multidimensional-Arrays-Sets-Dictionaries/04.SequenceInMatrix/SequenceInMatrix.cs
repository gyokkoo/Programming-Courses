namespace _04.SequenceInMatrix
{
    using System;
    using System.Linq;

    public class SequenceInMatrix
    {
        public static void Main()
        {
            string[,] matrix =
                {
                    { "ha", "fifi", "ho", "hi" },
                    { "fo", "ha", "hi", "xx" },
                    { "xxx", "ho", "ha", "xx" },
                };

            //string[,] matrix =
            //     {
            //        { "s", "qq", "s", },
            //        { "pp", "pp", "s" },
            //        { "pp", "qq", "s" },
            //    };

            int maxSequence = 0;
            int currentSequence = 1;
            string element = string.Empty;

            // Vertically
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        element = matrix[row, col];
                    }
                }
            }

            // Horizontally
            currentSequence = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        element = matrix[row, col];
                    }
                }
            }

            // Diagonally
            currentSequence = 1;
            for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    element = matrix[row, col];
                }
            }

            string[] maxSequenceArr = new string[maxSequence];
            for (int i = 0; i < maxSequence; i++)
            {
                maxSequenceArr[i] = element;
            }

            Console.WriteLine(string.Join(", ", maxSequenceArr));
        }
    }
}
