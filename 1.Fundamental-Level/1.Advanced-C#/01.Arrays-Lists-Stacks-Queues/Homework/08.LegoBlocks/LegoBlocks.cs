namespace _08.LegoBlocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] firstJaggedArray = new int[rows][];
            int[][] secondJaggedArray = new int[rows][];

            FillArray(firstJaggedArray);
            FillArray(secondJaggedArray);

            ReverseArray(secondJaggedArray);

            if (CheckMatrix(firstJaggedArray, secondJaggedArray))
            {
                PrintFitMatrix(firstJaggedArray, secondJaggedArray);
            }
            else
            {
                int cellsCount = GetCellsCount(firstJaggedArray, secondJaggedArray);
                Console.WriteLine("The total number of cells is: " + cellsCount);
            }
        }

        private static int GetCellsCount(int[][] firstArr, int[][] secondArr)
        {
            int cellsCount = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                cellsCount += firstArr[i].Length;
                cellsCount += secondArr[i].Length;
            }

            return cellsCount;
        }

        private static void PrintFitMatrix(int[][] firstArr, int[][] secondArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.Write("[" + string.Join(", ", firstArr[i]) + ", ");
                Console.WriteLine(string.Join(", ", secondArr[i]) + "]");
            }
        }

        private static bool CheckMatrix(int[][] firstArr, int[][] secondArr)
        {
            int firstRowLength = firstArr[0].Length + secondArr[0].Length;

            for (int row = 0; row < firstArr.Length; row++)
            {
                if (firstRowLength != firstArr[row].Length + secondArr[row].Length)
                {
                    return false;
                }
            }

            return true;
        }

        private static void ReverseArray(int[][] secondJaggedArray)
        {
            for (int i = 0; i < secondJaggedArray.Length; i++)
            {
                Array.Reverse(secondJaggedArray[i]);
            }
        }

        private static void FillArray(int[][] array)
        {
            char[] splitChars = { ' ' };

            for (int row = 0; row < array.Length; row++)
            {
                array[row] =
                    Console.ReadLine()
                        .Split(splitChars, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            }
        }
    }
}