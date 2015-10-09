using System;
using System.Collections.Generic;

class PlusRemove
{
    static void Main()
    {
        char[][] firstJaggedArr = new char[101][];
        char[][] secondJaggedArr = new char[101][];

        string inputLine = Console.ReadLine();

        int rows = 0;

        while (inputLine != "END")
        {
            FillJaggedArray(firstJaggedArr, rows, inputLine);

            FillJaggedArray(secondJaggedArr, rows, inputLine);

            inputLine = Console.ReadLine();

            rows++;
        }

        RemovePlus(rows, firstJaggedArr, secondJaggedArr);

        LeftShiftSpaces(rows, secondJaggedArr);

        PrintJaggedArray(secondJaggedArr, rows);

    }

    private static void FillJaggedArray(char[][] jaggedArray, int rows, string inputLine)
    {
        jaggedArray[rows] = new char[inputLine.Length];

        for (int j = 0; j < inputLine.Length; j++)
        {
            jaggedArray[rows][j] = inputLine[j];
        }
    }

    static void RemovePlus(int rows, char[][] firstJaggedArr, char[][] secondJaggedArray)
    {
        for (int i = 1; i < rows - 1; i++)
        {
            for (int j = 1; j < firstJaggedArr[i].Length - 1; j++)
            {
                if (isInsideArray(firstJaggedArr, i, j))
                {
                    if (char.ToLower(firstJaggedArr[i][j]) == char.ToLower(firstJaggedArr[i - 1][j]) &&
                        char.ToLower(firstJaggedArr[i][j]) == char.ToLower(firstJaggedArr[i][j - 1]) &&
                        char.ToLower(firstJaggedArr[i][j]) == char.ToLower(firstJaggedArr[i][j + 1]) &&
                        char.ToLower(firstJaggedArr[i][j]) == char.ToLower(firstJaggedArr[i + 1][j]))
                    {
                        secondJaggedArray[i - 1][j] = '\0';
                        secondJaggedArray[i][j - 1] = '\0';
                        secondJaggedArray[i][j] = '\0';
                        secondJaggedArray[i][j + 1] = '\0';
                        secondJaggedArray[i + 1][j] = '\0';
                    }
                }
            }
        }
    }

    static bool isInsideArray(char[][] jaggedArray, int i, int j)
    {
        bool isInsideArray = true;
        try
        {
            int tryToCatchExcetion =   (jaggedArray[i - 1][j] +
                                        jaggedArray[i][j - 1] + 
                                        jaggedArray[i][j] + 
                                        jaggedArray[i][j + 1] + 
                                        jaggedArray[i + 1][j]);
        }
        catch (Exception)
        {
            isInsideArray = false;
        }
        return isInsideArray;
    }

    static void LeftShiftSpaces(int rows, char[][] secondJaggedArr)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < secondJaggedArr[i].Length; j++)
            {
                if (secondJaggedArr[i][j] == '\0')
                {
                    for (int k = j; k < secondJaggedArr[i].Length; k++)
                    {
                        if (secondJaggedArr[i][k] != '\0')
                        {
                            secondJaggedArr[i][j] = secondJaggedArr[i][k];
                            secondJaggedArr[i][k] = '\0';
                            break;
                        }
                    }
                }
            }
        }
    }

    static void PrintJaggedArray(char[][] secondJaggedArr, int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < secondJaggedArr[i].Length; j++)
            {
                Console.Write(secondJaggedArr[i][j]);
            }
            Console.WriteLine();
        }
    }
}
