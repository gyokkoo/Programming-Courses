using System;

/*
Write a method that checks if the element at given position in a given array of integers 
is larger than its two neighbours (when such exist).

 */
class LargerThanNeighbours
{
    static void Main()
    {
        Console.Title = "Problem 3.	Larger Than Neighbours";

        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
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
                isLarger = numbers[i] > numbers[i + 1];
            }
            else if (i == numbers.Length - 1)
            {
                isLarger = numbers[i] > numbers[i - 1];
            }
            else
            {
                isLarger = (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]);
            }
        }

        return isLarger;
    }
}