using System;
using System.Linq;
/*
Write a method that returns the index of the first element in array that is larger than its neighbours, 
or -1 if there's no such element. Use the method from the previous exercise in order to re. 
 */
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Title = "Problem 4.	First Larger Than Neighbours";
        Console.WriteLine("Enter an array of number, separated by a space.");

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(numbers));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        int index = -1;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i - 1] < numbers[i] && numbers[i] > numbers[i + 1])
            {
                index = i;
            }
        }
   
        return index;
    }
}