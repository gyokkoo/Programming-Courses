using System;
using System.Linq;
/*
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour
elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.  
 */
class SequenceInMatrix
{
    static void Main()
    {
        Console.Title = "Problem 4.	Sequence in Matrix";

        string[,] matrix =
        {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
        };

        //Comment -> Ctrl + K, Ctrl + C
        //Uncomment -> Ctrl + K, Ctrl + U

        //{
        //    {"s", "qq", "s"},
        //    {"pp", "pp", "s"},
        //    {"pp", "qq", "s"},
        //};


        int longestSeq = 1;
        int currentSeq = 1;
        string itemValue = "";

        //horizontally
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }

                if (longestSeq < currentSeq)
                {
                    longestSeq = currentSeq;
                    itemValue = matrix[row, col];
                }
            }
            currentSeq = 1;
        }

        //vertically
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentSeq++;
                }
                else
                {
                    currentSeq = 1;
                }
                if (longestSeq < currentSeq)
                {
                    longestSeq = currentSeq;
                    itemValue = matrix[row, col];
                }
            }
            currentSeq = 1;
        }

        //diagonally
        for (int row = 0, col = 0; row < matrix.GetLength(1) - 1 && col < matrix.GetLength(0) - 1; row++, col++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (longestSeq < currentSeq)
            {
                longestSeq = currentSeq;
                itemValue = matrix[row, col];
            }
        }

        string[] longestSequenceArray = new string[longestSeq];

        for (int i = 0; i < longestSeq; i++)
        {
            longestSequenceArray[i] = itemValue;
        }

        Console.WriteLine(string.Join(", ", longestSequenceArray));
    }
}
