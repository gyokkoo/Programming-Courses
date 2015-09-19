using System;
using System.Linq;

/*
This problem is from the Java Basics Exam (8 February 2015).  
 */
class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] firstJaggedArray = new int[n][];
        int[][] secondJaggedArray = new int[n][];

        FillJaggedArray(firstJaggedArray);
        FillJaggedArray(secondJaggedArray);

        ReverseJaggedArray(secondJaggedArray);

        int[][] legoMatrix = new int[n][];

        if (IsFitting(firstJaggedArray, secondJaggedArray))
        {
            legoMatrix = joinArrays(firstJaggedArray, secondJaggedArray, legoMatrix);
            for (int i = 0; i < legoMatrix.Length; i++)
            {
                Console.WriteLine("[" + string.Join(", ", legoMatrix[i]) + "]");
            }
        }
        else
        {
            int countOfCells = GetCountOfCells(firstJaggedArray, secondJaggedArray);
            Console.WriteLine("The total number of cells is: {0}", countOfCells);
        }
    }

    static int GetCountOfCells(int[][] firstJaggedArray, int[][] secondJaggedArray)
    {
        int counfOfCells = 0;
        for (int i = 0; i < firstJaggedArray.Length; i++)
        {
            int leftSide = firstJaggedArray[i].Length;
            int rightSide = secondJaggedArray[i].Length;

            counfOfCells += (leftSide + rightSide);
        }

        return counfOfCells;
    }

    static int[][] joinArrays(int[][] firstJaggedArray, int[][] secondJaggedArray, int[][] combinedMatrix)
    {
        int matrixLength = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
        for (int i = 0; i < firstJaggedArray.Length; i++)
        {
            combinedMatrix[i] = new int[matrixLength];
            int k = 0;
            for (int j = 0; j < combinedMatrix[i].Length; j++)
            {
                if (j < firstJaggedArray[i].Length)
                {
                    combinedMatrix[i][j] = firstJaggedArray[i][j];
                }
                else if (j < matrixLength)
                {
                    combinedMatrix[i][j] = secondJaggedArray[i][k];
                    k++;
                }
            }
        }

        return combinedMatrix;
    }

    static bool IsFitting(int[][] firstJaggedArray, int[][] secondJaggedArray)
    {
        bool isFitting = true;

        int legoLength = firstJaggedArray[0].Length + secondJaggedArray[0].Length;

        for (int i = 0; i < firstJaggedArray.Length; i++)
        {
            if (firstJaggedArray[i].Length + secondJaggedArray[i].Length != legoLength)
            {
                isFitting = false;
            }
        }

        return isFitting;
    }

    static void ReverseJaggedArray(int[][] jaggedArray)
    {
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            int[] innerArray = jaggedArray[i];
            Array.Reverse(innerArray);
        }
    }

    static void FillJaggedArray(int[][] jaggedArray)
    {
        char[] emptySpaces = { ' ' };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            jaggedArray[i] = Console.ReadLine()
                            .Trim()
                            .Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}
