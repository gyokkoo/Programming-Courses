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

        int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(arrayOfNumbers));
    }

    static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))
            {
                return i;
            }
        }

        return -1;
    }
    static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool isLarger = false;

        if (numbers.Length == 1)
        {
            isLarger = false;
        }
        else
        {
            if (i == 0)
            {
                isLarger = numbers[i] > numbers[i + 1] ? true : false;
            }
            else if (i == numbers.Length - 1)
            {
                isLarger = numbers[i] > numbers[i - 1] ? true : false;
            }
            else
            {
                isLarger = (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]) ? true : false;
            }
        }

        return isLarger;
    }
}
