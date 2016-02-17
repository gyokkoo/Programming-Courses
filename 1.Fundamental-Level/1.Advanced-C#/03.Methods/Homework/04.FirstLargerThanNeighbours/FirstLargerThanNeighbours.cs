namespace _04.FirstLargerThanNeighbours
{
    using System;

    public class FirstLargerThanNeighbours
    {
        public static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
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

        private static bool IsLargerThanNeighbours(int[] numbers, int i)
        {
            if (numbers.Length == 1)
            {
                return false;
            }

            if (i == 0)
            {
                return numbers[i] > numbers[i + 1];
            }

            if (i == numbers.Length - 1)
            {
                return numbers[i] > numbers[i - 1];
            }

            return numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];
        }
    }
}