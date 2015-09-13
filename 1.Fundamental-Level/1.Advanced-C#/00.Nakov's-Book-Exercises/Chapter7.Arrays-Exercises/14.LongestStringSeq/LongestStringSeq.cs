using System;
/*
Write a program, which finds the longest sequence of equal string
elements in a matrix. A sequence in a matrix we define as a set of
neighbor elements on the same row, column or diagonal.
 */
class LongestStringSeq
{
    static void Main()
    {
        Console.Write("Rows = ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Columns = ");
        int columns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, columns];

        Console.WriteLine("Fill the matrix each row on a single line, seperated by a space");

        for (int row = 0; row < rows; row++)
        {
            string[] inputRow = Console.ReadLine().Split();
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = inputRow[col];
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