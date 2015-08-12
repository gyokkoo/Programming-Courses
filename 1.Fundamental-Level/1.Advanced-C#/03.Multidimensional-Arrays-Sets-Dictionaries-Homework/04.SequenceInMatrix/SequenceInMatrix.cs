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
        Console.WriteLine("Enter a matrix of size N x M. (Each row on a single line, separated by a space)");

        Console.Write("N = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int columns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            string[] colArr = Console.ReadLine().Split().ToArray();
            for (int col = 0; col < colArr.Length; col++)
            {
                matrix[row, col] = colArr[col];
            }
        }

        int longestSeq = 1;
        int currentSeq = 1;
        string itemValue = "";

        //horizontally
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns - 1; col++)
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
        for (int col = 0; col < columns; col++)
        {
            for (int row = 0; row < rows - 1; row++)
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
        for (int row = 0, col = 0; row < rows - 1 && col < columns - 1; row++, col++)
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
        currentSeq = 1;

        string[] outputArr = new string[longestSeq];
        for (int i = 0; i < outputArr.Length; i++)
        {
            outputArr[i] = itemValue;
        }
        Console.WriteLine("Longest sequence of equal strings in the matrix:");
        Console.WriteLine(string.Join(", ", outputArr));
    }
}
