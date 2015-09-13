using System;
using System.Linq;
/*
Write a program, which finds the maximal sequence of consecutive equal elements in an array. 
E.g.: {1, 1, 2, 3, 2, 2, 2, 1}  {2, 2, 2}. 
 */
class SequenceEqualElements
{
    static void Main()
    {
        Console.WriteLine("Enter an array of integers in a single line, seperated by a comma.");

        char[] emptySpaces = new char[] { ' ', ',', '{', '}' };
        int[] myArray = Console.ReadLine().Split(emptySpaces, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int bestStart = 0;
        int bestLength = 1;
        int curLength = 1;

        for (int i = 1; i < myArray.Length; i++)
        {

            if (myArray[i - 1] == myArray[i])
            {
                curLength += 1;
            }
            else
            {
                curLength = 1;
            }

            if (bestLength < curLength)
            {
                bestLength = curLength;
                bestStart = i - bestLength + 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write(myArray[i] + " ");
        }
        Console.WriteLine();
    }
}