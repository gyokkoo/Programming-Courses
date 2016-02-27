namespace _01.PlusRemove
{
    using System;
    using System.Collections.Generic;

    public class PlusRemove
    {
        public static void Main()
        {
            string textLine = Console.ReadLine();

            List<string> lines = new List<string>();
            while (textLine != "END")
            {
                lines.Add(textLine);
                textLine = Console.ReadLine();
            }

            char[][] jaggedMatrix = new char[lines.Count][];
            char[][] resultMatrix = new char[lines.Count][];

            for (int row = 0; row < jaggedMatrix.Length; row++)
            {
                jaggedMatrix[row] = new char[lines[row].Length];
                resultMatrix[row] = new char[lines[row].Length];
                for (int col = 0; col < jaggedMatrix[row].Length; col++)
                {
                    jaggedMatrix[row][col] = char.ToLower(lines[row][col]);
                    resultMatrix[row][col] = lines[row][col];
                }
            }

            RemovePlusShapes(jaggedMatrix, resultMatrix);

            PrintArray(resultMatrix);
        }

        private static void RemovePlusShapes(char[][] jaggedMatrix, char[][] resultMatrix)
        {
            for (int row = 1; row < jaggedMatrix.Length - 1; row++)
            {
                for (int col = 1; col < jaggedMatrix[row].Length - 1; col++)
                {
                    if (CheckPlusShape(jaggedMatrix, row, col))
                    {
                        resultMatrix[row][col] = '\0';
                        resultMatrix[row - 1][col] = '\0';
                        resultMatrix[row + 1][col] = '\0';
                        resultMatrix[row][col - 1] = '\0';
                        resultMatrix[row][col + 1] = '\0';
                    }
                }
            }
        }

        private static void PrintArray(char[][] arr)
        {
            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    if (arr[row][col] != '\0')
                    {
                        Console.Write(arr[row][col]);
                    }
                }

                Console.WriteLine();
            }
        }

        private static bool CheckPlusShape(char[][] jaggedMatrix, int row, int col)
        {
            try
            {
                return jaggedMatrix[row][col] == jaggedMatrix[row - 1][col]
                       && jaggedMatrix[row][col] == jaggedMatrix[row][col - 1]
                       && jaggedMatrix[row][col] == jaggedMatrix[row][col + 1]
                       && jaggedMatrix[row][col] == jaggedMatrix[row + 1][col];
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
    }
}
