using System;
using System.Linq;
using System.Collections.Generic;
/*
 Write a program which reads a string matrix from the console and performs certain operations with its elements. 
 User input is provided like in the problem above – first you read the dimensions and then the data. 
 Remember, you are not required to do this step first, you may add this functionality later.  
 Your program should then receive commands in format: "swap x1 y1 x2 y2" where x1, x2, y1, y2 are coordinates in the matrix. 
 In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). 
 You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and 
 print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
 If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), 
 print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered. 
 */
class MatrixShuffling
{
    static void Main()
    {
        Console.Title = "Problem 3.	Matrix shuffling";
        Console.WriteLine("Enter rows, columns, data and commands in a separate line.");

        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] commandArray = command.Split().ToArray();

            if (commandArray[0] == "swap" && commandArray.Length == 5)
            {
                int x1 = int.Parse(commandArray[1]);
                int y1 = int.Parse(commandArray[2]);
                int x2 = int.Parse(commandArray[3]);
                int y2 = int.Parse(commandArray[4]);

                if (x1 < rows && y1 < columns && x2 < rows && y2 < columns)
                {
                    swapElements(matrix, x1, y1, x2, y2);
                    printMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            command = Console.ReadLine();
        }
    }
    static void printMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static void swapElements(string[,] matrix, int x1, int y1, int x2, int y2)
    {
        string exchangeValue = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = exchangeValue;
    }
}