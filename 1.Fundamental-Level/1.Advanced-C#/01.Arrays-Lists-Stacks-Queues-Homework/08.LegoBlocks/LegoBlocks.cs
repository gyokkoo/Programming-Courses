using System;
using System.Collections.Generic;
using System.Linq;
/*
This problem is from the Java Basics Exam (8 February 2015).  
 */
class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[][] firstJaggedArr = new string[n][];
        string[][] secondJaggedArr = new string[n][];

        char[] emptySpace = new char[] { ' ', '\t' };

        for (int i = 0; i < n; i++)
        {
            string firstRaw = Console.ReadLine().Trim();
            firstJaggedArr[i] = firstRaw.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries).ToArray().ToArray();
        }

        for (int i = 0; i < n; i++)
        {
            string secondRaw = Console.ReadLine().Trim();
            secondJaggedArr[i] = secondRaw.Split(emptySpace, StringSplitOptions.RemoveEmptyEntries).ToArray().ToArray();

            Array.Reverse(secondJaggedArr[i]);
        }

        bool isFit = true;

        int legoRowLenght = firstJaggedArr[0].Length + secondJaggedArr[0].Length;
        int allBlocksCounter = legoRowLenght;

        for (int i = 1; i < n; i++)
        {
            int leftSide = firstJaggedArr[i].Length;
            int rightSide = secondJaggedArr[i].Length;
            allBlocksCounter += (leftSide + rightSide);

            if (firstJaggedArr[i].Length + secondJaggedArr[i].Length != legoRowLenght)
            {
                isFit = false;
            }
        }

        if (isFit)
        {
            string[][] legoFit = new string[n][];

            for (int i = 0; i < n; i++)
            {
                legoFit[i] = firstJaggedArr[i].Concat(secondJaggedArr[i]).ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", legoFit[i]));
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", allBlocksCounter);
        }
    }
}
