using System;
/*
Write a program, which compares two arrays of type char lexicographically (character by character)
and checks, which one is first in the lexicographical order. 
 */
class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter two arrays of chars, each array on single line.");

        char[] firstArray = Console.ReadLine().ToCharArray();
        char[] secondArray = Console.ReadLine().ToCharArray();

        if (firstArray.Length <= secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is first in the lexicographical order.");
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is first in the lexicographical order.");
                    break;
                }
                else if (i == firstArray.Length - 1)
                {
                    Console.WriteLine("The first array is first in the lexicographical order.");
                    break;
                }
            }
        }
        else if (firstArray.Length >= secondArray.Length)
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (secondArray[i] < firstArray[i])
                {
                    Console.WriteLine("The second array is first in the lexicographical order.");
                    break;
                }
                else if (secondArray[i] > firstArray[i])
                {
                    Console.WriteLine("The first array is first in the lexicographical order.");
                    break;
                }
                else if (i == secondArray.Length - 1)
                {
                    Console.WriteLine("The second array is first in the lexicographical order.");
                    break;
                }
            }
        }
        else if (firstArray.Length == secondArray.Length)
        {
            bool isEqual = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine("The two arrays are equal.");
            }
        }

    }
}