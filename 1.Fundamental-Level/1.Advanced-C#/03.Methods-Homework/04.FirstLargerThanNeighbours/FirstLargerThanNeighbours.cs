using System;

/*
Write a method that returns the index of the first element in array that is larger than its neighbours, 
or -1 if there's no such element. Use the method from the previous exercise in order to re. 
Output
3
-1
-1
 */
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.Title = "Problem 4.	First Larger Than Neighbours";

        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 }; ;

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));

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