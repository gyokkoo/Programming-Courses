using System;
using System.Collections.Generic;

/*
This problem is originally from the JavaScript Basics Exam (28 July 2014). 
You may check your solution here.
https://judge.softuni.bg/Contests/Practice/Index/84#1
*/

class StringMatrixRotation
{
    static void Main()
    {
        string[] command = Console.ReadLine().TrimEnd(')').Split('(');
        int rotation = int.Parse(command[1]) % 360;

        List<string> inputLists = new List<string>();
        string line = Console.ReadLine();

        while (line != "END")
        {
            inputLists.Add(line);

            line = Console.ReadLine();
        }

        int matrixRows = inputLists.Count;
        int matrixColumns = GetMaxColumn(inputLists);

        string[,] matrix = CreateMatrix(matrixRows, matrixColumns, inputLists);

        switch (rotation)
        {
            case 0:
                PrintMatrix(matrix);
                break; ;
            case 90:
                PrintRotate90(matrix);
                break;
            case 180:
                Rotate180(matrix);
                break;
            case 270:
                Rotate270(matrix);
                break;
        }
    }

    static void Rotate270(string[,] matrix)
    {
        for (int row = matrix.GetLength(1) - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                Console.Write(matrix[col, row]);
            }
            Console.WriteLine();
        }
    }

    static void Rotate180(string[,] matrix)
    {
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void PrintRotate90(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
            {
                Console.Write(matrix[col, row]);
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(string[,] matrix)
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

    static string[,] CreateMatrix(int matrixRows, int matrixColumns, List<string> inputLists)
    {
        string[,] matrix = new string[matrixRows, matrixColumns];

        for (int row = 0; row < matrixRows; row++)
        {
            for (int col = 0; col < matrixColumns; col++)
            {
                matrix[row, col] = inputLists[row].PadRight(matrixColumns, ' ')[col].ToString();
            }
        }

        return matrix;
    }

    static int GetMaxColumn(List<string> inputList)
    {
        int maxColumn = 0;
        for (int i = 0; i < inputList.Count; i++)
        {
            int currentColumnLength = inputList[i].Length;
            if (maxColumn < currentColumnLength)
            {
                maxColumn = currentColumnLength;
            }
        }

        return maxColumn;
    }
}