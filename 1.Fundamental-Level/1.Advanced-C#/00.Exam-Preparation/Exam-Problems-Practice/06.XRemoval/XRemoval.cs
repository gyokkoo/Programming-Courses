namespace _06.XRemoval
{
    using System;

    public class XRemoval
    {
        public static void Main()
        {
            char[][] inputArr = new char[101][];
            char[][] resultArr = new char[101][];
            string line = Console.ReadLine();
            int maxRows = 0;
            while (line != "END")
            {
                inputArr[maxRows] = new char[line.Length];
                resultArr[maxRows] = new char[line.Length];
                for (int i = 0; i < line.Length; i++)
                {
                    inputArr[maxRows][i] = line[i];
                    resultArr[maxRows][i] = line[i];
                }

                maxRows++;
                line = Console.ReadLine();
            }

            RemoveX(maxRows, inputArr, resultArr);

            LeftShiftSpaces(maxRows, resultArr);

            PrintJaggedArray(maxRows, resultArr);
        }

        private static void LeftShiftSpaces(int maxRows, char[][] resultArr)
        {
            for (int i = 0; i < maxRows; i++)
            {
                char[] innerArray = resultArr[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    if (resultArr[i][j] == ' ')
                    {
                        for (int k = j; k < resultArr[i].Length; k++)
                        {
                            if (resultArr[i][k] != ' ')
                            {
                                resultArr[i][j] = resultArr[i][k];
                                resultArr[i][k] = ' ';
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void RemoveX(int maxRows, char[][] inputArr, char[][] resultArr)
        {
            for (int i = 1; i < maxRows; i++)
            {
                char[] innerArray = inputArr[i];
                for (int j = 1; j < innerArray.Length; j++)
                {
                    if (IsValidX(inputArr, i, j))
                    {
                        resultArr[i][j] = ' ';
                        resultArr[i - 1][j - 1] = ' ';
                        resultArr[i - 1][j + 1] = ' ';
                        resultArr[i + 1][j - 1] = ' ';
                        resultArr[i + 1][j + 1] = ' ';
                    }
                }
            }
        }

        private static bool IsValidX(char[][] inputArr, int i, int j)
        {
            try
            {
                return char.ToUpper(inputArr[i][j]) == char.ToUpper(inputArr[i - 1][j - 1])
                       && char.ToUpper(inputArr[i][j]) == char.ToUpper(inputArr[i - 1][j + 1])
                       && char.ToUpper(inputArr[i][j]) == char.ToUpper(inputArr[i + 1][j - 1])
                       && char.ToUpper(inputArr[i][j]) == char.ToUpper(inputArr[i + 1][j + 1]);
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        private static void PrintJaggedArray(int maxRows, char[][] jaggedArray)
        {
            for (int i = 0; i < maxRows; i++)
            {
                char[] innerArray = jaggedArray[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.Write(innerArray[j]);
                }

                Console.WriteLine();
            }
        }
    }
}