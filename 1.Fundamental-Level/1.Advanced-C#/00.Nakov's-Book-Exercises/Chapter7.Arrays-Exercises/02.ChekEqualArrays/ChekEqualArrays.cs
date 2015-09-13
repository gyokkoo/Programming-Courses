using System;
using System.Linq;
/*
Write a program, which reads two arrays from the console and checks whether they are equal 
(two arrays are equal when they are of equal length and all of their elements, which have the same index, are equal). 
 */
class ChekEqualArrays
{
    static void Main()
    {
        Console.WriteLine("Enter two arrays of numbers, each array in a single line, numbers are separated by a space.");

        int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        bool isEqual = false;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if(firstArray[i] == secondArray[i])
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                    break;
                }
            }
        }

        Console.WriteLine("Arrays are equal ? --> {0}", isEqual);
    }
}